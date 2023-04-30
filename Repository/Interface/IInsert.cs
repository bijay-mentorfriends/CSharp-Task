namespace InternTask.Repository.Interface
{
    public interface IInsert
    {
        Task<string> Save(dynamic data);
        Task<dynamic> Update(dynamic data);
        Task<dynamic> Delete(string id);

    }
}
