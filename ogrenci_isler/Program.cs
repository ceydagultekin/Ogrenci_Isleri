
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenci_isler
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();
            Ogrenci ogrenci = new Ogrenci();
            Console.WriteLine("202013709001 S.CEYDA GÜLTEKİN NESNEYE YÖNELİK PROGRAMLAMA FİNAL PROJESİ " + "\n");
            studentManager.AddStudent(new Ogrenci
            {
                Ad = "Hilal",
                SoyAd = "Ömür",
                TC = "12345678911",
                Dogum_tarihi = new DateTime(2001, 11, 03),
                Dogum_yeri = "İstanbul",
                Cinsiyet = "Kadın",
                E_posta = "hilalomur@gmail.com",
                Telefon = "05331245874",
                Bolum = "Psikoloji" + "\n"
            });

            ogrenci.Add();
            Console.WriteLine("");


            TeacherManager teacherManager = new TeacherManager();
            Ogretim_Gorevlisi ogretim_Gorevlisi = new Ogretim_Gorevlisi();
            teacherManager.AddTeacher(new Ogretim_Gorevlisi
            {
                Ad = "Merve ",
                SoyAd = "Aydın",
                TC = "98765432120",
                Dogum_tarihi = new DateTime(2001, 09, 16),
                Dogum_yeri = "İstanbul",
                Cinsiyet = "Kadın",
                E_posta = "merveaydin@gmail.com",
                Telefon = "05447865214",
                Brans = "Matematik" + "\n"
            });
            ogretim_Gorevlisi.Add();

            studentManager.UpdateStudent(new Ogrenci { Telefon = "05421594786" });
            Console.WriteLine("");
            ogrenci.Update();
            Console.WriteLine("");

            DepartmentManager departmentManager = new DepartmentManager();
            Departmant departmant = new Departmant();
            departmentManager.DepartmentAdd(new Departmant { Bolum = "Bilgisayar Mühendisliği" });
            departmant.Add();

            LessonManager lessonManager = new LessonManager();
            Lesson lesson = new Lesson();
            lessonManager.LessonAdd(new Lesson { Brans = "Elektronik Devreler" });
            lesson.Add();
            Console.ReadKey();


        }
        interface IUniversity
        {
            string Fakulte { get; set; }
            string Bolum { get; set; }
            string Ogretmen { get; set; }
            string Brans { get; set; }

            void Add();


        }
        interface Iperson
        {
            string Ad { get; set; }
            string SoyAd { get; set; }
            string TC { get; set; }
            DateTime Dogum_tarihi { get; set; }
            string Dogum_yeri { get; set; }
            string Cinsiyet { get; set; }
            string E_posta { get; set; }
            string Telefon { get; set; }

            void Add();
            void Update();


        }
        class Ogrenci : Iperson
        {
            public string Ad { get; set; }
            public string SoyAd { get; set; }
            public string TC { get; set; }
            public DateTime Dogum_tarihi { get; set; }
            public string Dogum_yeri { get; set; }
            public string Cinsiyet { get; set; }
            public string E_posta { get; set; }
            public string Telefon { get; set; }

            public string Bolum { get; set; }
            public void Add()
            {

                Console.WriteLine("Öğrenci kayıt işlemi tamamlandı.");
            }
            public void Update()
            {
                Console.WriteLine("Öğrenci güncelleme işlemi tamamlandı");
            }

        }
        class Ogretim_Gorevlisi : Iperson
        {
            public string Ad { get; set; }
            public string SoyAd { get; set; }
            public string TC { get; set; }
            public DateTime Dogum_tarihi { get; set; }
            public string Dogum_yeri { get; set; }
            public string Cinsiyet { get; set; }
            public string E_posta { get; set; }
            public string Telefon { get; set; }
            public string Brans { get; set; }

            public void Add()
            {

                Console.WriteLine("Öğretim görevlisi kayıt işlemi tamamlandı.");
            }
            public void Update()
            {
                Console.WriteLine("Öğretim görevlisi güncelleme işlemi tamamlandı");
            }


        }
        class StudentManager
        {
            public virtual void AddStudent(Ogrenci ogrenci)
            {
                Console.WriteLine("Ad:{0}", ogrenci.Ad);
                Console.WriteLine("Soyad:{0}", ogrenci.SoyAd);
                Console.WriteLine("Tc:{0}", ogrenci.TC);
                Console.WriteLine("Doğum tarihi:{0}", ogrenci.Dogum_tarihi);
                Console.WriteLine("Doğum yeri:{0}", ogrenci.Dogum_yeri);
                Console.WriteLine("Cinsiyet:{0}", ogrenci.Cinsiyet);
                Console.WriteLine("Eposta:{0}", ogrenci.E_posta);
                Console.WriteLine("Telefon:{0}", ogrenci.Telefon);
                Console.WriteLine("Bölüm:{0}", ogrenci.Bolum);
            }
            public virtual void UpdateStudent(Ogrenci ogrenci)
            {
                Console.WriteLine("Hilal Ömür adlı öğrencinin telefon bilgisi {0} olarak değişmiştir", ogrenci.Telefon);
            }
        }
        class TeacherManager
        {
            public virtual void AddTeacher(Ogretim_Gorevlisi ogretim_Gorevlisi)
            {
                Console.WriteLine("Ad:{0}", ogretim_Gorevlisi.Ad);
                Console.WriteLine("Soyad:{0}", ogretim_Gorevlisi.SoyAd);
                Console.WriteLine("Tc:{0}", ogretim_Gorevlisi.TC);
                Console.WriteLine("Doğum tarihi:{0}", ogretim_Gorevlisi.Dogum_tarihi);
                Console.WriteLine("Doğum yeri:{0}", ogretim_Gorevlisi.Dogum_yeri);
                Console.WriteLine("Cinsiyet:{0}", ogretim_Gorevlisi.Cinsiyet);
                Console.WriteLine("Eposta:{0}", ogretim_Gorevlisi.E_posta);
                Console.WriteLine("Telefon:{0}", ogretim_Gorevlisi.Telefon);
                Console.WriteLine("Branş:{0}", ogretim_Gorevlisi.Brans);

            }

        }

        class Departmant : IUniversity
        {
            public string Fakulte { get; set; }
            public string Bolum { get; set; }
            public string Ogretmen { get; set; }
            public string Brans { get; set; }

            public void Add()
            {
                Console.WriteLine("Bölüm ekleme işlemi tamamlanmıştır");
            }
        }


        class DepartmentManager
        {
            public virtual void DepartmentAdd(Departmant departmant)
            {
                Console.WriteLine("Üniversiteye {0} bölümü eklenmiştir", departmant.Bolum);
            }
        }
        class Lesson : IUniversity
        {
            public string Fakulte { get; set; }
            public string Bolum { get; set; }
            public string Ogretmen { get; set; }
            public string Brans { get; set; }

            public void Add()
            {
                Console.WriteLine("Ders ekleme işlemi tamamlanmıştır");
            }
        }
        class LessonManager
        {
            public virtual void LessonAdd(Lesson lesson)
            {
                Console.WriteLine("Üniversiteye {0} dersi eklenmiştir", lesson.Brans);
            }
        }


    }
}


