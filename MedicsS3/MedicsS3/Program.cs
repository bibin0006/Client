using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Amazon;
using Amazon.S3;
using Amazon.S3.Model;

// Add using statements to access AWS SDK for .NET services. 
// Both the Service and its Model namespace need to be added 
// in order to gain access to a service. For example, to access
// the EC2 service, add:
// using Amazon.EC2;
// using Amazon.EC2.Model;

namespace MedicsS3
{
    class Program
    {
        public static void Main(string[] args)
        {
            string S3BucketPlayerFiles = "tutorial-playerfiles-dotnet1234";
            string S3FolderKeyPlayerPhotos = "tutorial-photos/";
            string pictureS3Key = S3FolderKeyPlayerPhotos + ".png";

            AmazonS3 s3Client = AWSClientFactory.CreateAmazonS3Client(RegionEndpoint.USEast1);
            PutObjectRequest pictureObjectReq = new PutObjectRequest()
            .WithBucketName("Medics")
            .WithKey("1.png")
            .WithFilePath(filePath: @"C:\1.txt");
            s3Client.PutObject(pictureObjectReq);
            Console.Read();
            
        }
    }
}