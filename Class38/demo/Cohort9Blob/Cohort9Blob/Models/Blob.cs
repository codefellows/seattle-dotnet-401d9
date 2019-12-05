using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cohort9Blob.Models
{
    public class Blob
    {
        public CloudStorageAccount CloudStorageAccount { get; set; }
        public CloudBlobClient CloudBlobClient { get; set; }

        public Blob(IConfiguration configuration)
        {
            var storageCreds = new StorageCredentials(configuration["AzureStorageName"], configuration["AzureKey"]);
            CloudStorageAccount = new CloudStorageAccount(storageCreds, true);
            CloudBlobClient = CloudStorageAccount.CreateCloudBlobClient();
        }

        /// <summary>
        /// Get or create the container name within Azure Storage
        /// </summary>
        /// <param name="containerName">name of container we want to retrieve</param>
        /// <returns>full Azure Storage Container</returns>
        public async Task<CloudBlobContainer> GetContainer(string containerName)
        {
            CloudBlobContainer cbc = CloudBlobClient.GetContainerReference(containerName);
            await cbc.CreateIfNotExistsAsync();
            await cbc.SetPermissionsAsync(new BlobContainerPermissions
            {
                PublicAccess = BlobContainerPublicAccessType.Blob
            });

            return cbc;
        }

        /// <summary>
        /// Upload a file directly to Azure Storage account given a container name
        /// </summary>
        /// <param name="container">name of container to place blob</param>
        /// <param name="filename">name of file/blob</param>
        /// <param name="filepath">location where file is located before upload</param>
        /// <returns>async task void</returns>
        public async Task UploadFile(CloudBlobContainer container, string filename, string filepath)
        {
            var blobFile = container.GetBlockBlobReference(filename);
            await blobFile.UploadFromFileAsync(filepath);
        }

        public async Task<CloudBlob> GetBlob(string imageName, string containerName)
        {
            var container = await GetContainer(containerName);

            CloudBlob blob = container.GetBlobReference(imageName);
            return blob;
        }

        public async Task DeleteBlob(CloudBlobContainer container, string filename)
        {
            CloudBlockBlob cbb = container.GetBlockBlobReference(filename);

            await cbb.DeleteAsync();
        }
    }
}
