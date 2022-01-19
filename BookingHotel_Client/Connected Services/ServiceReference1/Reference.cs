﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookingHotel_Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        string Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<string> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Register", ReplyAction="http://tempuri.org/IService1/RegisterResponse")]
        string Register(string username, string password, string nama);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Register", ReplyAction="http://tempuri.org/IService1/RegisterResponse")]
        System.Threading.Tasks.Task<string> RegisterAsync(string username, string password, string nama);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TambahTransaksi", ReplyAction="http://tempuri.org/IService1/TambahTransaksiResponse")]
        string TambahTransaksi(System.DateTime tgl_checkin, string nama, int ktp, int totalhari);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TambahTransaksi", ReplyAction="http://tempuri.org/IService1/TambahTransaksiResponse")]
        System.Threading.Tasks.Task<string> TambahTransaksiAsync(System.DateTime tgl_checkin, string nama, int ktp, int totalhari);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TambahDetailTransaksi", ReplyAction="http://tempuri.org/IService1/TambahDetailTransaksiResponse")]
        string TambahDetailTransaksi(int id_trans, int id_kamar, int subtotal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TambahDetailTransaksi", ReplyAction="http://tempuri.org/IService1/TambahDetailTransaksiResponse")]
        System.Threading.Tasks.Task<string> TambahDetailTransaksiAsync(int id_trans, int id_kamar, int subtotal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RemoveDetailTransaksi", ReplyAction="http://tempuri.org/IService1/RemoveDetailTransaksiResponse")]
        string RemoveDetailTransaksi(int id_detailtrans);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RemoveDetailTransaksi", ReplyAction="http://tempuri.org/IService1/RemoveDetailTransaksiResponse")]
        System.Threading.Tasks.Task<string> RemoveDetailTransaksiAsync(int id_detailtrans);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CekotTrans", ReplyAction="http://tempuri.org/IService1/CekotTransResponse")]
        string CekotTrans(int id_trans, int total);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CekotTrans", ReplyAction="http://tempuri.org/IService1/CekotTransResponse")]
        System.Threading.Tasks.Task<string> CekotTransAsync(int id_trans, int total);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllTrans", ReplyAction="http://tempuri.org/IService1/GetAllTransResponse")]
        BookingHotel_Service.DetailTrans[] GetAllTrans(int id_trans);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllTrans", ReplyAction="http://tempuri.org/IService1/GetAllTransResponse")]
        System.Threading.Tasks.Task<BookingHotel_Service.DetailTrans[]> GetAllTransAsync(int id_trans);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDetailTransByIDTrans", ReplyAction="http://tempuri.org/IService1/GetDetailTransByIDTransResponse")]
        BookingHotel_Service.DetailTrans[] GetDetailTransByIDTrans(int id_trans);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDetailTransByIDTrans", ReplyAction="http://tempuri.org/IService1/GetDetailTransByIDTransResponse")]
        System.Threading.Tasks.Task<BookingHotel_Service.DetailTrans[]> GetDetailTransByIDTransAsync(int id_trans);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CekotKamar", ReplyAction="http://tempuri.org/IService1/CekotKamarResponse")]
        string CekotKamar(string status, int avaibility);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CekotKamar", ReplyAction="http://tempuri.org/IService1/CekotKamarResponse")]
        System.Threading.Tasks.Task<string> CekotKamarAsync(string status, int avaibility);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : BookingHotel_Client.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<BookingHotel_Client.ServiceReference1.IService1>, BookingHotel_Client.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public string Register(string username, string password, string nama) {
            return base.Channel.Register(username, password, nama);
        }
        
        public System.Threading.Tasks.Task<string> RegisterAsync(string username, string password, string nama) {
            return base.Channel.RegisterAsync(username, password, nama);
        }
        
        public string TambahTransaksi(System.DateTime tgl_checkin, string nama, int ktp, int totalhari) {
            return base.Channel.TambahTransaksi(tgl_checkin, nama, ktp, totalhari);
        }
        
        public System.Threading.Tasks.Task<string> TambahTransaksiAsync(System.DateTime tgl_checkin, string nama, int ktp, int totalhari) {
            return base.Channel.TambahTransaksiAsync(tgl_checkin, nama, ktp, totalhari);
        }
        
        public string TambahDetailTransaksi(int id_trans, int id_kamar, int subtotal) {
            return base.Channel.TambahDetailTransaksi(id_trans, id_kamar, subtotal);
        }
        
        public System.Threading.Tasks.Task<string> TambahDetailTransaksiAsync(int id_trans, int id_kamar, int subtotal) {
            return base.Channel.TambahDetailTransaksiAsync(id_trans, id_kamar, subtotal);
        }
        
        public string RemoveDetailTransaksi(int id_detailtrans) {
            return base.Channel.RemoveDetailTransaksi(id_detailtrans);
        }
        
        public System.Threading.Tasks.Task<string> RemoveDetailTransaksiAsync(int id_detailtrans) {
            return base.Channel.RemoveDetailTransaksiAsync(id_detailtrans);
        }
        
        public string CekotTrans(int id_trans, int total) {
            return base.Channel.CekotTrans(id_trans, total);
        }
        
        public System.Threading.Tasks.Task<string> CekotTransAsync(int id_trans, int total) {
            return base.Channel.CekotTransAsync(id_trans, total);
        }
        
        public BookingHotel_Service.DetailTrans[] GetAllTrans(int id_trans) {
            return base.Channel.GetAllTrans(id_trans);
        }
        
        public System.Threading.Tasks.Task<BookingHotel_Service.DetailTrans[]> GetAllTransAsync(int id_trans) {
            return base.Channel.GetAllTransAsync(id_trans);
        }
        
        public BookingHotel_Service.DetailTrans[] GetDetailTransByIDTrans(int id_trans) {
            return base.Channel.GetDetailTransByIDTrans(id_trans);
        }
        
        public System.Threading.Tasks.Task<BookingHotel_Service.DetailTrans[]> GetDetailTransByIDTransAsync(int id_trans) {
            return base.Channel.GetDetailTransByIDTransAsync(id_trans);
        }
        
        public string CekotKamar(string status, int avaibility) {
            return base.Channel.CekotKamar(status, avaibility);
        }
        
        public System.Threading.Tasks.Task<string> CekotKamarAsync(string status, int avaibility) {
            return base.Channel.CekotKamarAsync(status, avaibility);
        }
    }
}
