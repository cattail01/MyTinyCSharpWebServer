using System.Net.Sockets;

namespace SimpleCSharpServer;

/// <summary>
/// http server的处理程序
/// </summary>
public abstract class HttpServer
{
    /// <summary>
    /// ip端口号
    /// </summary>
    private int _port;

    private int Port
    {
        get => _port;
        set => _port = value;
    }

    /// <summary>
    /// tcp 监听器
    /// </summary>
    private TcpListener _listener;

    private TcpListener Listener
    {
        get => _listener;
        set => _listener = value;
    }

    private bool _isActive;


    /// <summary>
    /// 构造函数，用于初始化类
    /// </summary>
    /// <param name="port">ip端口号</param>
    protected HttpServer(int port)
    {
        Port = port;
    }

    public void Listen()
    {
        // 创建tcp listener
        Listener = new TcpListener(Port);
        // 开始监听
        Listener.Start();
        // 守护线程
        while (_isActive)
        {
            // 当listener收到tcp请求时，创建一个tcp连接

        }
    }

    /// <summary>
    /// 处理get请求的抽象函数
    /// 留给实现server的类实现
    /// </summary>
    public abstract void HandleGetRequest(HttpProcessor p);

    /// <summary>
    /// 处理post请求的抽象函数
    /// 同样留给实现server的类实现
    /// </summary>
    /// <param name="p">http处理程序</param>
    /// <param name="inputData"></param>
    public abstract void HandlePostRequest(HttpProcessor p, StreamReader inputData);
}
