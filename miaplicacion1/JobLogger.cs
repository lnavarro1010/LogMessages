using System;
using MySql.Data.MySqlClient;
using System.IO;
using System.Linq;
using System.Text;    
public class JobLogger  {       
    private static bool _logToFile;
    private static bool _logToConsole;
    private static bool _logMessage;
    private static bool _logWarning;
    private static bool _logError;
    private static bool LogToDatabase;
    private bool _initialized;
    public JobLogger(bool logToFile, bool logToConsole, bool logToDatabase, bool  logMessage, bool logWarning, bool logError)
    {   _logError = logError;
        _logMessage = logMessage;
        _logWarning = logWarning;
        LogToDatabase = logToDatabase;
        _logToFile = logToFile;
        _logToConsole = logToConsole;
        _initialized = true;
    }
    public static String LogMessage(string message, bool is_message, bool warning, bool  error)
    {
        String rdo = "";
        message.Trim();
        if (message == null || message.Length == 0)
        {
            return rdo;
            
        }
        if (!_logToConsole && !_logToFile && !LogToDatabase)
        { 
            throw new Exception("Invalid configuration");
        }          
        if ((!_logError && !_logMessage && !_logWarning) || (!is_message && !warning  && !error))
        {
            throw new Exception("Error or Warning or Message must be specified");
        }
        try
        {
            int t = 0;
            string l = "";
            
            if (error && _logError)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                t = 3;
                l = l + DateTime.Now.ToShortDateString() + " " + "ERROR " + message + Environment.NewLine;
             }
            if (warning && _logWarning)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                t = 2;
                l = l + DateTime.Now.ToShortDateString() + " " + "WARNING " + message + Environment.NewLine;
             }
            if (is_message && _logMessage)
            {
                Console.ForegroundColor = ConsoleColor.White;
                t = 1;
                l = l + DateTime.Now.ToShortDateString() + " " + "INFO " + message + Environment.NewLine;
            }
            if (_logToConsole) { 
                Console.WriteLine(l);
                rdo = "c";
            }
           
            if (_logToFile) {  
                bool f = LogMessageToFile(l);
                rdo = rdo + "f"+f.ToString();
            }
           
            if (LogToDatabase) { 
                int bd = LogMessageToDatabase(message, t);
                rdo = rdo + "b"+bd.ToString();
            }

            
        }
        catch( Exception e)
        {
            Console.WriteLine(" se produjo la excepcón  en la aplicacion" + e);
        }
        return rdo;

    }
    public static int LogMessageToDatabase(string message,int t)
    {
        int rdo ;
        string conectionstr = System.Configuration.ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
        MySqlConnection conn = new MySqlConnection(conectionstr);

        conn.Open();
        MySqlCommand command = new MySqlCommand("Insert into Log(message,type) Values('" + message + "', " + t.ToString() + ")", conn);
        rdo = command.ExecuteNonQuery();
        conn.Close();
        return rdo;
    }
    public static bool LogMessageToFile(string line)
    {
        bool rdo = false;
        string nameFile = System.Configuration.ConfigurationManager.AppSettings["LogFileDirectory"] + "LogFile" + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString() + ".txt";
        int lineas = 0;
        if (File.Exists(nameFile)){
            lineas = File.ReadAllLines(nameFile).Length;
        };
        StreamWriter sw = new StreamWriter(nameFile, true);
        sw.Write(line);
        sw.Close();
        if (File.ReadAllLines(nameFile).Length> lineas){
            rdo = true;
        }
        return rdo;
    }
}     
 