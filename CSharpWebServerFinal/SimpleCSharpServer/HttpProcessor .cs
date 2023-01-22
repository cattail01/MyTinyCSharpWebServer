using System.Net.Sockets;

namespace SimpleCSharpServer;

/// <summary>
/// 网络连接的处理程序
/// </summary>
public class HttpProcessor
{
    /// <summary>
    /// tcp客户端
    /// </summary>
    private TcpClient _tcpClient;

    public TcpClient TcpClient
    {
        get => _tcpClient;
        set => _tcpClient = value;
    }

    /// <summary>
    /// http 服务器
    /// </summary>
    private HttpServer _server;

    public HttpServer Server
    {
        get => _server;
        set => _server = value;
    }



    /// <summary>
    /// 网络流的输入流
    /// </summary>
    private Stream inputStream;

    /// <summary>
    /// 网络流的输出流
    /// </summary>
    private StreamWriter outputStream;

    /// <summary>
    /// 构造函数，初始化
    /// </summary>
    /// <param name="tcpClient">TcpClient</param>
    /// <param name="server">HttpServer</param>
    public HttpProcessor(TcpClient tcpClient, HttpServer server)
    {
        this.TcpClient = tcpClient;
        this.Server = server;
        // 获取network stream 输入输出流
        NetworkStream networkStream = TcpClient.GetStream();
        // 将network stream网络输入流转换为buffered stream 具有缓冲区的流
        inputStream = new BufferedStream(networkStream);
        // 将network stream网络输出流转换为buffered stream。
        // 并将该buffered stream转换为write stream 专门用于写入的流
        outputStream = new StreamWriter(new BufferedStream(networkStream));
    }

    ~HttpProcessor()
    {
        // 流的资源释放
        inputStream.Close();
        outputStream.Close();
        inputStream.Dispose();
        outputStream.Dispose();
    }

    /// <summary>
    /// 处理程序主体
    /// </summary>
    public void Process()
    {
        
    }

    public void parseRequest()
    {

    }

    public void readHeaders()
    {

    }

    /// <summary>
    /// 从输入流中读取一行数据
    /// </summary>
    /// <param name="inputStream"></param>
    /// <returns></returns>
    private string StreamReadLine(Stream inputStream)
    {
        throw new Exception();
    }
}