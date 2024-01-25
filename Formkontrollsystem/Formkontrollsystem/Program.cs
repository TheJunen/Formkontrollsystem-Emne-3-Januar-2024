namespace Formkontrollsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Form> ListeAvFormer = new List<Form>();
            ListeAvFormer.AddRange(new List<Form>
            {
                new Sirkel(3.0, "cm2", "sirkel1", "blå"),
                new Sirkel(7.8, "dm2", "sirkel2", "gul"),
                new Rektangel(5, 4, "dm2", "rektangel1", "lilla"),
                new Rektangel(10,23, "dm2", "rektangel2", "rød"),
                new Trekant(6, 6, "dm2", "trekant1", "svart"),
                new Trekant(12, 14, "cm2", "trekant2", "tricolor")
            });
            foreach (Form form in ListeAvFormer)
            {
                Console.WriteLine(form.PrintUtAreal());
            }

            Console.WriteLine("Sortert ListeAvFormer ifølge størrelse på arealverdi:");

            List<Form> sortedList = ListeAvFormer.OrderBy(form => form.BeregnAreal()).ToList();
            foreach (Form form2 in sortedList)
            {
                form2.BeregnAreal();
                Console.WriteLine(form2.PrintUtAreal());
            }
            ////var listeteller = ListeAvFormer.Count();

            ////Console.WriteLine(listeteller);
            ////Program program = new Program();
            //program.TotaltAreal(ListeAvFormer);
        }

        //private void TotaltAreal(List <Form> listeavformer)
        //{
        //    foreach (Form form in listeavformer)
        //    {
        //        double TotaltArea;
        //        TotaltArea++(form.BeregnAreal());
        //        i;
        //    }
        //}
        //private void FargeFiltrering(List<Form> ListeAvFormer)
        //{
        //    if (Sirkel.Farge == "blå" || "rød" || "svart")
        //    {

        //    }
        //    //List<Form> filtrertliste = ListeAvFormer.Where(s => s.StartsWith("blå, ")).ToList();
        //}
    }
}



