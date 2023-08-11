﻿namespace Server.Service.Interfaces
{
    public interface IBlobService
    {
        Task<string> GetBlob(string blobName, string containerName);
        Task<string> DeleteBlob(string blobName, string containerNamer);
        Task<string> UploadBlob(string blobName, string containerName, IFormFile file);
    }
}
