namespace WestcoastEducation.Interfaces;

public interface IStorage<T> where T : class
{
    List<T> Read(string path);
    void Write(List<T> data, string path);
}
