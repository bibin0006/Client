using System;
using System.IO;
using Amazon;
using Amazon.S3.Model;

namespace MedicsS3
{
   public static class S3Util
   {
       private const String BucketName = "Medics";
 

       public static void UploadFile(string filePath,string destinationName)
        {
            var s3Client = AWSClientFactory.CreateAmazonS3Client(RegionEndpoint.USEast1);
             var pictureObjectReq = new PutObjectRequest()
            .WithBucketName(BucketName)
            .WithKey(destinationName)
            .WithFilePath(filePath);
            s3Client.PutObject(pictureObjectReq);
            Console.Read();
        }

       public static void UploadFileStream(string destinationName, Stream inputStream)
       {
           var s3Client = AWSClientFactory.CreateAmazonS3Client(RegionEndpoint.USEast1);
           var pictureObjectReq = new PutObjectRequest();
           pictureObjectReq.WithBucketName(BucketName).WithKey(destinationName).WithInputStream(inputStream);
           S3Response response = s3Client.PutObject(pictureObjectReq);
           response.Dispose();      
       }



       public static Stream DownloadFileStream(string fileName)
       {
           var s3Client = AWSClientFactory.CreateAmazonS3Client(RegionEndpoint.USEast1);
           var request = new GetObjectRequest().WithBucketName(BucketName).WithKey(fileName);
           using (S3Response getObjectResponse = s3Client.GetObject(request))
           return getObjectResponse.ResponseStream;
        
       }
       public static void DownloadFile(string fileName, string destinationPath)
       {
           //try
           {
               var s3Client = AWSClientFactory.CreateAmazonS3Client(RegionEndpoint.USEast1);
         
               var request = new GetObjectRequest().WithBucketName(BucketName).WithKey(fileName);

               using (var response = s3Client.GetObject(request))
               {
                   var title = response.Metadata["x-amz-meta-title"];
                   Console.WriteLine("The object's title is {0}", title);
                   var dest = Path.Combine(destinationPath, fileName);
                   if (!File.Exists(dest))
                   {
                       response.WriteResponseStreamToFile(dest);
                   }
               }
           }
           //catch (AmazonS3Exception amazonS3Exception)
           //{
           //    if (amazonS3Exception.ErrorCode != null &&
           //        (amazonS3Exception.ErrorCode.Equals("InvalidAccessKeyId") ||
           //        amazonS3Exception.ErrorCode.Equals("InvalidSecurity")))
           //    {
           //        Console.WriteLine("Please check the provided AWS Credentials.");
           //        Console.WriteLine("If you haven't signed up for Amazon S3, please visit http://aws.amazon.com/s3");
           //    }
           //    else
           //    {
           //        Console.WriteLine("An error occurred with the message '{0}' when reading an object", amazonS3Exception.Message);
           //    }
           //}
       }

       
       
    }
}
