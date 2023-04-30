using InternTask.Repository.Interface;

namespace InternTask.Repository.Implement
{
    public class Concept : IConcept
    {
        public Task<dynamic> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<string> Save(dynamic data)
        {
            throw new NotImplementedException();
        }

        public Task<dynamic> Update(dynamic data)
        {
            throw new NotImplementedException();
        }
    }
}
