using System.Net;

namespace Calc_IP_gui;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btn_policz_Click(object sender, EventArgs e)
    {//policz i wyswietl
        try
        {
            string ipInput = tb_ip.Text.Trim();
            string maskInput = tb_mask.Text.Trim();
            
            string[] splitIp = ipInput.Split('.');
            string[] splitMask = maskInput.Split('.');
            
    //walidacja
            if (!CheckIPparts(splitIp))
            {
                MessageBox.Show("Adres IP jest niepoprawny. Upewnij się, że jest w formacie X.X.X.X, gdzie X to liczba 0–255.", "Błąd");
                return;
            }
            if (!CheckIPparts(splitMask))
            {
                MessageBox.Show("Maska podsieci jest niepoprawna. Upewnij się, że jest w formacie X.X.X.X, gdzie X to liczba 0–255.", "Błąd");
                return;
            }
    //string[] na int[]
            int[] intIp = ConvertToInt(splitIp);
            int[] intMask = ConvertToInt(splitMask); 
    //reprezentacja binarna w tab string[]
            string[] binIp = ConvertToBin(intIp);
            string[] binMask = ConvertToBin(intMask);
    //ciaglosc maski
            if (!CheckMask(binMask))
            {
                MessageBox.Show("maska jest niepoprawna, brak ciągłości", "Błąd");
                return;
            }
    //klasa sieci            
            string klasasieci = Klasa(intIp);
    //adres sieci
            string[] netbinadd = AdresSieci(binIp, binMask);
            int[] netdecadd = ConvertToDec(netbinadd);
    //adres broadcast
            string[] braddec = BAdres(binMask, netdecadd);
            string[] bradbin = ConvertToBin(ConvertToInt(braddec));
    //liczba hostow
            int netbit = NetBits(binMask);
    //pierwszy adr1es hosta
            int[]fone = [0,0,0,1];
            for (int i = 0; i < fone.Length; i++)
            {
                fone[i] = fone[i] + netdecadd[i];
            }
            string[] binfone = ConvertToBin(fone);
    //ostatni adres hosta
            int[]lone = [0,0,0,-1];
            int[]decbrad = ConvertToDec(bradbin);
            for (int i = 0; i < lone.Length; i++)
            {
                lone[i] = lone[i] + decbrad[i];
            }

            string[] binlone = ConvertToBin(lone);
    //+separator
    
            
            
            
            
    //wyswietlanie:            
            ip_dec.Text = ipInput;
            ip_bin.Text = string.Join(".",WstawSep(binIp, netbit));
            mask_dec.Text = maskInput;
            mask_bin.Text = string.Join(".",WstawSep(binMask, netbit));
            adres_dec.Text = string.Join(".",netdecadd);
            adres_bin.Text = string.Join(".",WstawSep(netbinadd, netbit));
            adresR_dec.Text = string.Join(".",braddec);
            adresR_bin.Text = string.Join(".",WstawSep(bradbin, netbit));
            
            host_dec.Text = PossibleHosts(netbit);
            min_dec.Text = string.Join(".", fone);
            min_bin.Text = string.Join(".", WstawSep(binfone, netbit));
            max_dec.Text = string.Join(".", lone);
            max_bin.Text = string.Join(".", WstawSep(binlone, netbit));
            klasa_out.Text = klasasieci;
        }
        catch (Exception ex)//obsluga bledow
        {
            MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 
        
    }//koniec
//metody
//walidacja input
    private bool CheckIPparts(string[] parts)
    {
        //czy 4 oktety?
        if (parts.Length != 4)
        {
            return false;
        }
        //znaki 0-9? zakres 0-255?
        foreach (string part in parts)
        {
            if (!CheckValid(part))
            {
                return false;
            }
        }
        return true;
    }

    private bool CheckValid(string input)
    {
        //czy cyfry?
        foreach (char c in input)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        //czy 0-255?
        if (int.TryParse(input, out int value))
        {
            return value >= 0 && value <= 255;
        }
        return false;//jesli blad
    }
//konwersja string[] na int[]
    private int[] ConvertToInt(string[] input)
    {
        int[] output = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            output[i] = int.Parse(input[i]);
        }
        return output;
    }

//konwersja tabl int dec na tab string bin
    private string[] ConvertToBin(int[] input)
    {
        string[] output = new string[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            output[i] = DecToBin(input[i]);
        }
        return output;
    }
//konwersja intdec na bin zapisane jako string
    private string DecToBin(int input)
    {
        if (input == 0 ) return "00000000";

        string output = String.Empty;
        
        while (input > 0)
        {
            int remainder = input % 2;
            output = remainder + output;
            input = input / 2;
            
        }
        return output.PadLeft(8, '0');
    }
//konwersja string[]bin na int[]dec

    private int[] ConvertToDec(string[] input)
    {
        int[] output = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            output[i] = BinToDec(input[i]);
        }
        return output;
    }

    private int BinToDec(string input)
    {
        int output = 0;
        for (int i = 7; i >= 0; i--)
        {
            if (input[i] == '1')
            {
                output = output + (int)Math.Pow(2, 7-i);
            }
        }
        return output;
    }
//walidacja ciaglosci maski
    private bool CheckMask(string[] bininput)
    {
        string merge = string.Join("", bininput);
        bool found0 = false;
        foreach (char c in merge)
        {
            if (c == '0')
                found0 = true;
            else if (found0 && c == '1') //sprawdzenie czy po 0 wystepuje 1
                return false;
        }

        return true;
    }
    

//klasa sieci 
    private string Klasa(int[] input)
    {
        string output = null;
        if (input[0] <= 127 && input[0] >= 0)
        {
            output = "A";
        }
        else if (input[0] >= 128 && input[0] <= 191)
        {
            output = "B";
        }
        else if (input[0] >= 192 && input[0] <= 223)
        {
            output = "C";
        }
        else if (input[0] >= 224 && input[0] <= 239)
        {
            output = "D";
        }
        else if (input[0] >= 240 && input[0] <= 255)
        {
            output = "E";
        }

        return output;
    }
//network address
    private string OktetAdresSieci(string binip, string binmask)
    {
        char[] cbinip = binip.ToCharArray();
        char[] cbinmask = binmask.ToCharArray();
        char[] cbinnetwork = new char[cbinip.Length];
        for (int i = 0; i < cbinip.Length; i++)
        {
            if (cbinip[i] == '1' && cbinip[i] == cbinmask[i])
            {
                cbinnetwork[i] = '1';
            }
            else cbinnetwork[i] = '0';
        }
        string binnetwork = string.Join("", cbinnetwork);
        return binnetwork;
    }

    private string[] AdresSieci(string[] binip, string[] binmask)
    {
        string[] output = new string[binip.Length];
        for (int i = 0; i < binip.Length; i++)
        {
            output[i] = OktetAdresSieci(binip[i], binmask[i]);
        }
        return output;
    }
    
//broadcast address
    private string OktetBAdres(string binmask)
    {
        char[] cbinmask = binmask.ToCharArray();
        char[] cbinnot = new char[binmask.Length];
        for (int i = 0; i < binmask.Length; i++)
        {
            if (cbinmask[i] == '1')
            {
                cbinnot[i] = '0';
            }
            else cbinnot[i] = '1';
        }
        string brad = string.Join("", cbinnot);
        return brad;
    }

    private string[] BAdres(string[] binmask,int[] netdecadd)
    {//operacja not na bin string[]maski=>string[]bin na string[]dec
        string[] output = new string[binmask.Length];
        string[] notmaskbin = new string[binmask.Length];
        for (int i = 0; i < notmaskbin.Length; i++)
        {
            notmaskbin[i] = OktetBAdres(binmask[i]);
        }
        int[]decnmask = ConvertToDec(notmaskbin);
        for (int i = 0; i < decnmask.Length; i++)
        {
            output[i] = Convert.ToString(decnmask[i] + netdecadd[i]);
        }
        return output;
    }
//bity net/host
    private int NetBits(string[] bininput)
    {
        int nbit = 0;
        string merge = string.Join("", bininput);
       
        foreach (char c in merge)
        {
            if (c == '1')
                nbit++;
        }
        return nbit;
    }
//ile hostow
    private string PossibleHosts(int nbit)
    {
        string liczhostow = Convert.ToString((Math.Pow(2,32-nbit))-2);
        return liczhostow;
    }


//separator czesci net/host
    private string[] WstawSep(string[] bin, int netbits)
    {
        string[] output = new string[bin.Length];
        int currentindex = 0;
        for (int i = 0; i < bin.Length; i++)
        {
            string octet = bin[i];
            string separatedOctet = string.Empty;
            for (int j = 0; j < octet.Length; j++, currentindex++)
            {
                if (currentindex == netbits)
                {
                    separatedOctet += "|";
                }
                separatedOctet += octet[j];
            }
            output[i] = separatedOctet;
        }
        return output;
    }

}