using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_ornek2_777
{
    public partial class Form1 : Form
    {
  
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            int main()
            {

                int sayi, adet, i;
                int buyuk;

                printf("Kac Adet Sayi Girilecek? =  ");
                scanf("%d", &adet);

                //Kullanıcının istediği kadar( adet kadar ) sayı girmesini isteyen döngü        
                for (i = 0; i < adet; i++)
                {

                    printf("%d)Sayi Giriniz ", i + 1);  //Kullanıcının kaçıncı sayıyı girdiğini görmek için i+1 olarak gösteriyoruz
                    scanf("%d", &sayi);

                    if (i == 0)
                    {                // Döngü ilk döndüğünde yani i=0 da buyuk değişkenini sayiya eşitliyoruz.
                        buyuk = sayi;        // Bu eşitlemeyi yapmazsak eğer karşılaştıracak buyuk değeri olmayacak.
                    }

                    //Döngü ilk defa dönmüyorsa eğer!!!
                    else
                    {

                        //Buyuk değeri yeni girilen sayidan küçükse en büyük değer o olmadığı için buyuk değerini değiştiriyoruz.
                        if (buyuk < sayi)
                        {
                            buyuk = sayi;

                        }
    }
}
