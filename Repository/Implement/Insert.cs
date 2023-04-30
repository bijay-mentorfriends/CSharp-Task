using InternTask.Repository.Interface;

namespace InternTask.Repository.Implement
{

    public class Insert : IInsert
    {
        public Task<dynamic> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<dynamic> Update(dynamic data)
        {
            throw new NotImplementedException();
        }

        public async Task<string> Save(dynamic data)
        {
            
        }
    }
}
