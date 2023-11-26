namespace Logger;

public class NullLogger : Ilogger
{
    static readonly private Ilogger instance = new NullLogger();
    static public Ilogger Instance => instance;

    private NullLogger() { }
    public void Log(string message) { }




    // static private Ilogger instance;
    // static public Ilogger Instance
    // {
    //     get
    //     {
    //         if (instance == null) instance = new NullLogger();
    //         return instance;
    //     }
    // }


    // private NullLogger()
    // {

    // }

    // public void Log(string message)
    // {

    // }


}