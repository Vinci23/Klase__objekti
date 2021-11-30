using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasa_i_objekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();

            osoba.setIme("Pero");
            osoba.setGodinaRodjenja(1997);
            osoba.setPrezime("Perić");
            osoba.setVisina(182);
            osoba.setTezina(85);
            osoba.Spol = 'M';

           
            Console.WriteLine("Ime i prezime: "+osoba.getIme()+" "+ osoba.getPrezime());
            Console.WriteLine("Godina rođenja: "+osoba.getGodinaRodjenja()+".");
            Console.WriteLine("Visina: "+osoba.getVisina()+"cm");
            Console.WriteLine("Težina: "+osoba.getTezina()+"kg");
            Console.WriteLine("Spol: " + osoba.Spol);

            Osoba osoba1 = new Osoba("Ana", "Anić", 2001, 164, 62,'Ž');

            Console.WriteLine(osoba1.ToString());

            Console.ReadKey();
        }

    }   
    class Osoba
    {
            String ime, prezime;
            int godinaRodjenja, visina, tezina;
            char spol;

        public override string ToString()
        {
            string ispis = ("Ime i prezime: " + this.getIme() + " " + this.getPrezime() +"\n"+ 
                "Godina rođenja: " + this.getGodinaRodjenja() + "."+ "\n" + "Visina: " + this.getVisina() + "cm"
            +"\n" + "Težina: " + this.getTezina() + "kg"
           + "\n"+"Spol: " + this.Spol);
            return ispis;
        }

        public Osoba()
        {

        }

        public Osoba(String ime, String prezime, int godinaRodjenja, int visina, int tezina, char spol)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godinaRodjenja = godinaRodjenja;
            this.visina = visina;
            this.tezina = tezina;
            Spol = spol;
        }

        public char Spol { get => spol; set => spol = value; }

        public void setIme(String ime) 
        {
          
            this.ime = ime;
        
        }

        public void setGodinaRodjenja(int godinaRodjenja)
        {

            this.godinaRodjenja = godinaRodjenja;

        }

        public void setPrezime(String prezime) 
        {   
            this.prezime = prezime;
        }

        public void setVisina(int visina)
        {
            this.visina = visina;
        }

        public void setTezina(int tezina)
        {
            this.tezina = tezina; 
        }
        ///////////////////////////////////////////////////////
   
        public String getIme() 
        {
            
            return this.ime;
        }

        public int getGodinaRodjenja()
        {

            return this.godinaRodjenja;

        }

        public String getPrezime()
        {
            return this.prezime;
        }

        public int getVisina()
        {
            return this.visina;
        }

        public int getTezina()
        { 
            return this.tezina;
        }
    }
    

}
