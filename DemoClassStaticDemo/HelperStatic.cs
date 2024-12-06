namespace DemoClassStaticDemo
{
    public static class HelperStatic
    {
        //public static int Id { get; set; }

        public static void CleanForm(Control frm)
        {
            //Collection
            //int[]
            //ArrayList
            //List<T>
            //frm.Text = string.Empty;
            foreach (Control item in frm.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = string.Empty;
                }
                if (item is Panel || item is GroupBox)
                {
                    CleanForm(item);
                    //foreach (Control subitem in item.Controls)
                    //{
                    //    if (subitem is TextBox || subitem is ComboBox)
                    //    {
                    //        subitem.Text = string.Empty;
                    //    }
                    //}
                }

            }
        }
    }
}
