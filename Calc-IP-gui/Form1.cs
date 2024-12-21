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
            
            IPAddress ipAddress = IPAddress.Parse(ipInput);
            IPAddress subnetMask = IPAddress.Parse(maskInput);
            
            IPAddress networkAddress = GetNetworkAddress(ipAddress, subnetMask);
            IPAddress broadcastAddress = GetBroadcastAddress(ipAddress, subnetMask);
            int totalHosts = GetTotalHosts(subnetMask);

            ip_dec.Text = ipInput;
            mask_dec.Text = maskInput;
            adres_dec.Text = $"{networkAddress}";
            adresR_dec.Text = $"{broadcastAddress}";
            host_dec.Text = $"{totalHosts}";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 
        
    }
    private IPAddress GetNetworkAddress(IPAddress ipAddress, IPAddress subnetMask)
    {
        byte[] ipBytes = ipAddress.GetAddressBytes();
        byte[] maskBytes = subnetMask.GetAddressBytes();
        byte[] networkBytes = new byte[ipBytes.Length];

        for (int i = 0; i < ipBytes.Length; i++)
        {
            networkBytes[i] = (byte)(ipBytes[i] & maskBytes[i]);
        }

        return new IPAddress(networkBytes);
    }

    private IPAddress GetBroadcastAddress(IPAddress ipAddress, IPAddress subnetMask)
    {
        byte[] ipBytes = ipAddress.GetAddressBytes();
        byte[] maskBytes = subnetMask.GetAddressBytes();
        byte[] broadcastBytes = new byte[ipBytes.Length];

        for (int i = 0; i < ipBytes.Length; i++)
        {
            broadcastBytes[i] = (byte)(ipBytes[i] | ~maskBytes[i]);
        }

        return new IPAddress(broadcastBytes);
    }

    private int GetTotalHosts(IPAddress subnetMask)
    {
        byte[] maskBytes = subnetMask.GetAddressBytes();
        int totalBits = 0;

        foreach (byte b in maskBytes)
        {
            totalBits += CountBits(b);
        }

        return (int)Math.Pow(2, 32 - totalBits) - 2; // -2 dla adresu sieci i broadcast
    }

    private int CountBits(byte b)
    {
        int count = 0;
        while (b != 0)
        {
            count += b & 1;
            b >>= 1;
        }
        return count;
    }
}