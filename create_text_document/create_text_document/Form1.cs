using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //sistem kütüphanesi ekliyoruz
namespace create_text_document
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dosyadi, dosyayolu; //global alanda tanımlamamız gerekn değişkenler
        StreamWriter sw; //dosya oluşturma ,dosyaya yazı yazma işemlerinde kullanılıyor. akışyazıcısı

        private void button2_Click(object sender, EventArgs e)
        {
            dosyadi = textBox2.Text;
            sw = File.CreateText(dosyayolu + "\\" + dosyadi + ".txt"); //metin oluşturma metodu kullanıyoruz "createText"
            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( folderBrowserDialog1.ShowDialog()==DialogResult.OK ) //dialog pencerisi içerisinde tamam tuşuna basarsam
            {
                dosyayolu=folderBrowserDialog1.SelectedPath.ToString(); // folderBrowserDialog da seçilen dosyanın yolunu string formatta tut
                textBox1.Text = dosyayolu; // ve textBox1 e yazdır
            }
        }
    }
}
