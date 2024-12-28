namespace AssOOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("Print All Days :");
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day.ToString());

            //}

            #endregion
            #region Q2
            //SeasOn seasOn;
            //SeasOn season;
            //bool isParsed;
            //do
            //{
            //    Console.WriteLine("Enter your favourite Season :");
            //    isParsed = Enum.TryParse<SeasOn>(Console.ReadLine(), out season);
            //}
            //while (!isParsed );
            //{
            //    seasOn = season;
            //}
            //switch (seasOn) {
            //    case SeasOn.Spring:
            //        Console.WriteLine("the corresponding month range for that season : march to may");
            //        break;
            //    case SeasOn.Summer:
            //        Console.WriteLine("the corresponding month range for that season : june to august");
            //        break;
            //    case SeasOn.Autumn:
            //        Console.WriteLine("the corresponding month range for that season : September to November");
            //        break;
            //    case SeasOn.Winter:
            //        Console.WriteLine("the corresponding month range for that season : December to February");
            //        break;
            //    default:
            //        break;

            //}
            #endregion
            #region Q3
            //Permissions permissions = new Permissions();
            //permissions = Permissions.Delete;
            //Console.WriteLine(permissions.ToString());

            //// to add a permission
            //permissions ^= Permissions.Execute;
            //Console.WriteLine(permissions.ToString());
            //// to check if permission is existed or not
            //if ((permissions & Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("This permisson is existed");
            //}
            //else 
            //{
            //    permissions^= Permissions.Execute;
            //    Console.WriteLine(permissions.ToString());
            //}
            /////to check if existed 
            ///// do Nothing
            ///// else add it 
            //permissions |= Permissions.Execute;
            //Console.WriteLine(permissions.ToString());
            //permissions |= Permissions.Write;
            //Console.WriteLine(permissions.ToString());

            #endregion
            #region Q4
            //Colors colors;
            //bool isParsed=false;
            //Console.WriteLine("Enter Your Color");
            //Enum.TryParse<Colors>(Console.ReadLine(), out colors);
            //foreach (Colors col in Enum.GetValues(typeof(Colors))) 
            //{
            //    if (colors == col) {
            //        Console.WriteLine("This color is a primary color");
            //        isParsed = true;
            //        break;
            //    }

            //}
            //if (isParsed == false) 
            //{
            //    Console.WriteLine("This color isn't a primary color");

            //}
            //do {
            //    Console.WriteLine("Enter Your Color");
            //    isParsed = Enum.TryParse<Colors>(Console.ReadLine(), out colors);

            //}
            //while (!isParsed);
            #endregion
        }
    }
}
