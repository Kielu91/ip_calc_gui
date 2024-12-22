using System.Net;

namespace Calc_IP_gui;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btn_policz_Click(object sender, EventArgs e)
    {
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
            //reprezentacja binarna w postaci string[]
            string[] binIp = ConvertToBin(intIp);
            string[] binMask = ConvertToBin(intMask);
            
            
            

            ip_dec.Text = ipInput;
            ip_bin.Text = string.Join("",binIp);
            
            mask_dec.Text = maskInput;
            
            
            
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 
        
    }

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
//konwersja tablicy string na int
    private int[] ConvertToInt(string[] input)
    {
        int[] output = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            output[i] = int.Parse(input[i]);
        }
        return output;
    }
//tablica int na tablice string reprezentujaca jako dpostac binarna
    private string[] ConvertToBin(int[] input)
    {
        string[] output = new string[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            output[i] = DecToBin(input[i]);
        }
        return output;
    }
//konwersja int na bin zapisane jako string
    private string DecToBin(int input)
    {
        if (input == 0 ) return "0";
        
        string output = null;

        while (input > 0)
        {
            int remainder = input % 2;
            output = remainder + output;
            input = input / 2;
        }
        return output;
    } 
//walidacja ciaglosci maski
    
    

//klasa sieci 



//network address
    
    
    
    
//broadcast address
    
    
    
    
//bity net/host




//ile hostow




//host max



//host min




//separator czesci net/host
    
    
}