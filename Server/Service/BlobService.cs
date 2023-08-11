using Server.Service.Interfaces;

namespace Server.Service
{
    public class BlobService : IBlobService
    {
        public Task<string> DeleteBlob(string blobName, string containerNamer)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetBlob(string blobName, string containerName)
        {
            throw new NotImplementedException();
        }

        public Task<string> UploadBlob(string blobName, string containerName, IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}
