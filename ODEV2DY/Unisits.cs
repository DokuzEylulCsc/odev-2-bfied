using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ODEV2DY
{
    public class Universite
    {
        public string ad { get; set; }
        public List<Fakulte> fakulteler;
        public unimemento extract()
        {
            return new unimemento
            {
                ad = this.ad,
                fakulteler = this.fakulteler
            };
        }
        public void insert(unimemento uni)
        {
            this.ad = uni.ad;
            this.fakulteler = uni.fakulteler;
        }
        public void load()
        {
            foreach(Fakulte fak in Fakulte.get_array())
            {
                foreach (Bolum bol in Bolum.get_array(fak.ad))
                {
                    foreach(Ogretimelemani ogretimelemani in Ogretimelemani.get_array(bol.ad))
                    {
                        bol.ogretimelemanlari = new List<Ogretimelemani>();
                        bol.ogretimelemanlari.Add(ogretimelemani);
                    }
                    foreach(Ders ders in Ders.get_array(bol.ad))
                    {
                        foreach(Sube sube in Sube.get_array(ders.ad))
                        {
                            ders.subeler = new List<Sube>();
                            ders.subeler.Add(sube);
                            foreach(Ogretimelemani ogretimelemani in Ogretimelemani.get_array(""))
                            {
                                if (sube.ogretimelemani.ad == ogretimelemani.ad)
                                {
                                    sube.ogretimelemani = new Ogretimelemani();
                                    sube.ogretimelemani = ogretimelemani;
                                }
                            }
                        }
                       bol.dersler = new List<Ders>();
                       bol.dersler.Add(ders);
                    }
                    fak.bolumler = new List<Bolum>();
                    fak.bolumler.Add(bol);
                }
                fakulteler = new List<Fakulte>();
                fakulteler.Add(fak);
            }
        }
    }

    public class unimemento
    {
        public string ad { get; set; }
        public List<Fakulte> fakulteler;
    }

    public class Fakulte
    {
        public string ad { get; set; }
        public List<Bolum> bolumler;
        public static ArrayList get_array()
        {
            ArrayList ret = new ArrayList();
            Fakulte i;
            foreach (string line in Dosya.oku(Main.fak_path))
            {
                i = new Fakulte();
                i.ad = line;
                ret.Add(i);
            }
            return ret;
        }
    }
    public class Bolum
    {
        public string fakulte { get; set; }
        public string ad { get; set; }
        public List<Ders> dersler;
        public List<Ogretimelemani> ogretimelemanlari;
        public List<Ogr> ogrenciler;
        public static ArrayList get_array(string fak)
        {
            if (fak == "")
            {
                ArrayList ret = new ArrayList();
                Bolum i;
                string[] info;
                foreach (string line in Dosya.oku(Main.bol_path))
                {
                    i = new Bolum();
                    info = line.Split(',');
                    i.fakulte = info[0];
                    i.ad = info[1];
                    ret.Add(i);
                }
                return ret;
            }
            else
            {
                ArrayList ret = new ArrayList();
                Bolum i;
                string[] info;
                foreach (string line in Dosya.oku(Main.bol_path))
                {
                    i = new Bolum();
                    info = line.Split(',');
                    i.fakulte = info[0];
                    i.ad = info[1];
                    if (i.fakulte == fak)
                    {
                        ret.Add(i);
                    }
                }
                return ret;
            }
        }
    }

    public class Ders
    {
    public string bolum { get; set; }
    public string ad { get; set; }
        public List<Sube> subeler;
        public static ArrayList get_array(string bolum)
        {
            if(bolum == "")
            {
                ArrayList ret = new ArrayList();
                Ders i;
                string[] info;
                foreach (string line in Dosya.oku(Main.ders_path))
                {
                    i = new Ders();
                    info = line.Split(',');
                    i.bolum = info[0];
                    i.ad = info[1];
                    ret.Add(i);
                }
                return ret;
            }
            else
            { 
                ArrayList ret = new ArrayList();
                Ders i;
                string[] info;
                foreach (string line in Dosya.oku(Main.ders_path))
                {
                    i = new Ders();
                    info = line.Split(',');
                    i.bolum = info[0];
                    i.ad = info[1];
                    if(i.bolum==bolum)
                    {
                        ret.Add(i);
                    }
                    
                }
                return ret;
            }
           
        }
    }
    public class Sube
    {
        public string ders { get; set; }
        public string ad { get; set; }
        public Ogretimelemani ogretimelemani { get; set; }
        public List<Ogr> ogrenciler;
        public static ArrayList get_array(string ders)
        {
            if(ders == "")
            {
                ArrayList ret = new ArrayList();
                Sube i;
                string[] info;
                foreach (string line in Dosya.oku(Main.sube_path))
                {
                    i = new Sube();
                    info = line.Split(',');
                    i.ders = info[0];
                    i.ad = info[1];
                    ret.Add(i);
                }
                return ret;
            }
            else
            {
                ArrayList ret = new ArrayList();
                Sube i;
                string[] info;
                foreach (string line in Dosya.oku(Main.sube_path))
                {
                    i = new Sube();
                    info = line.Split(',');
                    i.ders = info[0];
                    i.ad = info[1];
                    if(i.ders==ders)
                    {
                        ret.Add(i);
                    }
                    
                }
                return ret;
            }
          
        }

    }

    public class Ogretimelemani
    {
        public string ad { get; set; }
        public string bolum { get; set; }
        public static ArrayList get_array(string bolum)
        {
            if (bolum == "")
            {
                ArrayList ret = new ArrayList();
                Ogretimelemani i;
                string[] info;
                foreach (string line in Dosya.oku(Main.ogreleman_path))
                {
                    i = new Ogretimelemani();
                    info = line.Split(',');
                    i.bolum = info[0];
                    i.ad = info[1];
                    ret.Add(i);
                }
                return ret;
            }
            else
            {
                ArrayList ret = new ArrayList();
                Ogretimelemani i;
                string[] info;
                foreach (string line in Dosya.oku(Main.sube_path))
                {
                    i = new Ogretimelemani();
                    info = line.Split(',');
                    i.bolum = info[0];
                    i.ad = info[1];
                    if (i.bolum == bolum)
                    {
                        ret.Add(i);
                    }

                }
                return ret;
            }

        }

    }



}
