﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using PrecizeSoft.IO.Wcf.ServiceContracts.Converter.V1;

namespace PrecizeSoft.IO.Wcf.Configuration.Converter.V1
{
    public class ServiceConfigurationManager
    {
        protected readonly string defaultAddress = "http://api.getpdf.online/Converter/V1/Service.svc";

        public string DefauldAddress
        {
            get
            {
                return this.defaultAddress;
            }
        }

        public Binding CreateBinding()
        {
            BasicHttpBinding binding = new BasicHttpBinding()
            {
                Namespace = "http://io.precizesoft.com/Converter/V1/",
                MaxBufferSize = 100 * 1024 * 1024, //for MTOM
                MaxReceivedMessageSize = 100 * 1024 * 1024,
                MessageEncoding = WSMessageEncoding.Mtom
            };
            return binding;
        }

        public ServiceEndpoint CreateServiceEndpoint(string address)
        {
            //ContractDescription contract = new ContractDescription(typeof(IService).ToString());
            ContractDescription contract = ContractDescription.GetContract(typeof(IService));
            ServiceEndpoint endpoint = new ServiceEndpoint(contract, this.CreateBinding(), new EndpointAddress(address));
            
            return endpoint;
        }
    }
}
