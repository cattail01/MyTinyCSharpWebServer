namespace SimpleCSharpServer;

/// <summary>
/// http server的实现类
/// </summary>
public class SimpleCSharpServer: HttpServer
{
    /// <summary>
    /// 构造函数：给基类赋值
    /// </summary>
    /// <param name="port">ip端口</param>
    public SimpleCSharpServer(int port): base(port)
    {

    }

    /// <summary>
    /// 处理get请求
    /// </summary>
    /// <param name="p"></param>
    /// <exception cref="NotImplementedException"></exception>
    public override void HandleGetRequest(HttpProcessor p)
    {
        throw new NotImplementedException();
    }

    public override void HandlePostRequest(HttpProcessor p, StreamReader inputData)
    {
        throw new NotImplementedException();
    }
}
