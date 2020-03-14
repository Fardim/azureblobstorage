using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NickAzure.Models
{
    public class BlobInfo
    {
        public Stream Content { get; }
        public string ContentType { get; }

        public BlobInfo(Stream content, string contentType)
        {
            Content = content;
            ContentType = contentType;
        }
    }
}
