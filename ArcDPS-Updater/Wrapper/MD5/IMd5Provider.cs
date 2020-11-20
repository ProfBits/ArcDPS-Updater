namespace ArcDPS_Updater.Wrapper.MD5
{
    public interface IMd5Provider
    {
        string GetMd5Hash(string filePath);
    }
}