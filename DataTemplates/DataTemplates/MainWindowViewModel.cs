using Prism.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
<<<<<<< HEAD
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
=======
>>>>>>> db97fe7c4e2bd0b872665cb83ce8c074b42b62cb

namespace DataTemplates
{
    public class MainWindowViewModel : BindableBase
    {
<<<<<<< HEAD
    private static void ReadOrderData(string connectionString)
    {
        string queryString = getrequete();

        using (SqlConnection connection =
                   new SqlConnection(connectionString))
        {
            SqlCommand command =
                new SqlCommand(queryString, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            // Call Read before accessing data.
            while (reader.Read())
            {
                ReadSingleRow((IDataRecord)reader);
            }

            // Call Close when done reading.
            reader.Close();
        }
    }

    private static String getrequete()
    {
        string path = @"C:\Users\ensimag\Projet-.NET\DataTemplates\DataTemplates\SQLQuery1.sql"; //chemin de ton fichier
        //
        StreamReader sr = null;
        //
        String line = null;

        try
        {
            sr = new StreamReader(path);
            line = sr.ReadToEnd();
        }
        catch (Exception ex)
        {
            throw ex;
        }

        return line;// cette variable stocke le contenu de ton fichier .sql
    }

    private static void ReadSingleRow(IDataRecord record)
    {
        Console.WriteLine(String.Format("{0}", record[0]));
    }


 
        public MainWindowViewModel()
        {
            string str = "Data Source=ingefin.ensimag.fr;Initial Catalog=DotNetDB;Persist Security Info=True;User ID=etudiant;Password=edn!2015";
        ReadOrderData(str);
        }
    }
}

=======
        private IClass selectedClass;

        public ObservableCollection<IClass> AvailableClasses { get; private set; }

        public IClass SelectedClass
        {
            get { return selectedClass; }
            set { SetProperty(ref selectedClass, value); }
        }

        public MainWindowViewModel()
        {
            IClass cl1 = new ClassA() { Number = 1 };
            IClass cl2 = new ClassB() { Text = "b1" };
            IClass cl3 = new ClassA() { Number = 2 };
            List<IClass> myList = new List<IClass>() { cl1, cl2, cl3 };
            AvailableClasses = new ObservableCollection<IClass>(myList);
        }
    }
}
>>>>>>> db97fe7c4e2bd0b872665cb83ce8c074b42b62cb
