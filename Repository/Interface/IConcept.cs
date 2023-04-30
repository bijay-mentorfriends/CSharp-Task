namespace InternTask.Repository.Interface
{
    public interface IConcept
    {
        Task<string> Save(dynamic data);
        Task<dynamic> Update(dynamic data);
        Task<dynamic> Delete(string id);
    }
}
