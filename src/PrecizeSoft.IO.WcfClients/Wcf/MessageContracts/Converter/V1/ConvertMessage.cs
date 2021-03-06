﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using PrecizeSoft.IO.Wcf.DataContracts.Converter.V1;

namespace PrecizeSoft.IO.Wcf.MessageContracts.Converter.V1
{
    [MessageContract]
    public class ConvertMessage
    {
        [MessageBodyMember]
        public string FileExtension { get; set; }

        [MessageBodyMember]
        public byte[] FileBytes { get; set; }

        [MessageBodyMember]
        public IEnumerable<CustomAttribute> CustomAttributes { get; set; }
    }
}
