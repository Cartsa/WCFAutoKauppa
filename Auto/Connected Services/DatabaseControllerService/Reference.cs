﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Auto.DatabaseControllerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AutoTesti", Namespace="http://schemas.datacontract.org/2004/07/AutoKauppaService")]
    [System.SerializableAttribute()]
    public partial class AutoTesti : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AutonMalliID1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AutonMerkkiID1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal Hinta1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Mittarilukema1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal Moottorin_tilavuus1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PolttoaineID1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Rekisteri_paivamaara1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int VaritID1Field;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AutonMalliID1 {
            get {
                return this.AutonMalliID1Field;
            }
            set {
                if ((this.AutonMalliID1Field.Equals(value) != true)) {
                    this.AutonMalliID1Field = value;
                    this.RaisePropertyChanged("AutonMalliID1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AutonMerkkiID1 {
            get {
                return this.AutonMerkkiID1Field;
            }
            set {
                if ((this.AutonMerkkiID1Field.Equals(value) != true)) {
                    this.AutonMerkkiID1Field = value;
                    this.RaisePropertyChanged("AutonMerkkiID1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Hinta1 {
            get {
                return this.Hinta1Field;
            }
            set {
                if ((this.Hinta1Field.Equals(value) != true)) {
                    this.Hinta1Field = value;
                    this.RaisePropertyChanged("Hinta1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID1 {
            get {
                return this.ID1Field;
            }
            set {
                if ((this.ID1Field.Equals(value) != true)) {
                    this.ID1Field = value;
                    this.RaisePropertyChanged("ID1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Mittarilukema1 {
            get {
                return this.Mittarilukema1Field;
            }
            set {
                if ((this.Mittarilukema1Field.Equals(value) != true)) {
                    this.Mittarilukema1Field = value;
                    this.RaisePropertyChanged("Mittarilukema1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Moottorin_tilavuus1 {
            get {
                return this.Moottorin_tilavuus1Field;
            }
            set {
                if ((this.Moottorin_tilavuus1Field.Equals(value) != true)) {
                    this.Moottorin_tilavuus1Field = value;
                    this.RaisePropertyChanged("Moottorin_tilavuus1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PolttoaineID1 {
            get {
                return this.PolttoaineID1Field;
            }
            set {
                if ((this.PolttoaineID1Field.Equals(value) != true)) {
                    this.PolttoaineID1Field = value;
                    this.RaisePropertyChanged("PolttoaineID1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Rekisteri_paivamaara1 {
            get {
                return this.Rekisteri_paivamaara1Field;
            }
            set {
                if ((this.Rekisteri_paivamaara1Field.Equals(value) != true)) {
                    this.Rekisteri_paivamaara1Field = value;
                    this.RaisePropertyChanged("Rekisteri_paivamaara1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int VaritID1 {
            get {
                return this.VaritID1Field;
            }
            set {
                if ((this.VaritID1Field.Equals(value) != true)) {
                    this.VaritID1Field = value;
                    this.RaisePropertyChanged("VaritID1");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AutonMerkki", Namespace="http://schemas.datacontract.org/2004/07/AutoKauppaService")]
    [System.SerializableAttribute()]
    public partial class AutonMerkki : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Merkki1Field;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID1 {
            get {
                return this.ID1Field;
            }
            set {
                if ((this.ID1Field.Equals(value) != true)) {
                    this.ID1Field = value;
                    this.RaisePropertyChanged("ID1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Merkki1 {
            get {
                return this.Merkki1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Merkki1Field, value) != true)) {
                    this.Merkki1Field = value;
                    this.RaisePropertyChanged("Merkki1");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AutonMalli", Namespace="http://schemas.datacontract.org/2004/07/AutoKauppaService")]
    [System.SerializableAttribute()]
    public partial class AutonMalli : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AutonMerkkiID1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Auton_mallin_nimi1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID1Field;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AutonMerkkiID1 {
            get {
                return this.AutonMerkkiID1Field;
            }
            set {
                if ((this.AutonMerkkiID1Field.Equals(value) != true)) {
                    this.AutonMerkkiID1Field = value;
                    this.RaisePropertyChanged("AutonMerkkiID1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Auton_mallin_nimi1 {
            get {
                return this.Auton_mallin_nimi1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Auton_mallin_nimi1Field, value) != true)) {
                    this.Auton_mallin_nimi1Field = value;
                    this.RaisePropertyChanged("Auton_mallin_nimi1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID1 {
            get {
                return this.ID1Field;
            }
            set {
                if ((this.ID1Field.Equals(value) != true)) {
                    this.ID1Field = value;
                    this.RaisePropertyChanged("ID1");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Polttoaine", Namespace="http://schemas.datacontract.org/2004/07/AutoKauppaService")]
    [System.SerializableAttribute()]
    public partial class Polttoaine : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Polttoaineen_nimi1Field;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID1 {
            get {
                return this.ID1Field;
            }
            set {
                if ((this.ID1Field.Equals(value) != true)) {
                    this.ID1Field = value;
                    this.RaisePropertyChanged("ID1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Polttoaineen_nimi1 {
            get {
                return this.Polttoaineen_nimi1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Polttoaineen_nimi1Field, value) != true)) {
                    this.Polttoaineen_nimi1Field = value;
                    this.RaisePropertyChanged("Polttoaineen_nimi1");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Vari", Namespace="http://schemas.datacontract.org/2004/07/AutoKauppaService")]
    [System.SerializableAttribute()]
    public partial class Vari : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AutonVari1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID1Field;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AutonVari1 {
            get {
                return this.AutonVari1Field;
            }
            set {
                if ((object.ReferenceEquals(this.AutonVari1Field, value) != true)) {
                    this.AutonVari1Field = value;
                    this.RaisePropertyChanged("AutonVari1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID1 {
            get {
                return this.ID1Field;
            }
            set {
                if ((this.ID1Field.Equals(value) != true)) {
                    this.ID1Field = value;
                    this.RaisePropertyChanged("ID1");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DatabaseControllerService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/connectDatabase", ReplyAction="http://tempuri.org/IService1/connectDatabaseResponse")]
        bool connectDatabase();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/connectDatabase", ReplyAction="http://tempuri.org/IService1/connectDatabaseResponse")]
        System.Threading.Tasks.Task<bool> connectDatabaseAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/saveAutoIntoDatabase", ReplyAction="http://tempuri.org/IService1/saveAutoIntoDatabaseResponse")]
        bool saveAutoIntoDatabase(Auto.DatabaseControllerService.AutoTesti newAuto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/saveAutoIntoDatabase", ReplyAction="http://tempuri.org/IService1/saveAutoIntoDatabaseResponse")]
        System.Threading.Tasks.Task<bool> saveAutoIntoDatabaseAsync(Auto.DatabaseControllerService.AutoTesti newAuto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllAutoMakersFromDatabase", ReplyAction="http://tempuri.org/IService1/getAllAutoMakersFromDatabaseResponse")]
        System.Collections.Generic.List<Auto.DatabaseControllerService.AutonMerkki> getAllAutoMakersFromDatabase();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllAutoMakersFromDatabase", ReplyAction="http://tempuri.org/IService1/getAllAutoMakersFromDatabaseResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Auto.DatabaseControllerService.AutonMerkki>> getAllAutoMakersFromDatabaseAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAutoModelsByMakerId", ReplyAction="http://tempuri.org/IService1/getAutoModelsByMakerIdResponse")]
        System.Collections.Generic.List<Auto.DatabaseControllerService.AutonMalli> getAutoModelsByMakerId(int makerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAutoModelsByMakerId", ReplyAction="http://tempuri.org/IService1/getAutoModelsByMakerIdResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Auto.DatabaseControllerService.AutonMalli>> getAutoModelsByMakerIdAsync(int makerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getCarFuel", ReplyAction="http://tempuri.org/IService1/getCarFuelResponse")]
        System.Collections.Generic.List<Auto.DatabaseControllerService.Polttoaine> getCarFuel();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getCarFuel", ReplyAction="http://tempuri.org/IService1/getCarFuelResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Auto.DatabaseControllerService.Polttoaine>> getCarFuelAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getColor", ReplyAction="http://tempuri.org/IService1/getColorResponse")]
        System.Collections.Generic.List<Auto.DatabaseControllerService.Vari> getColor();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getColor", ReplyAction="http://tempuri.org/IService1/getColorResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Auto.DatabaseControllerService.Vari>> getColorAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Eka", ReplyAction="http://tempuri.org/IService1/EkaResponse")]
        Auto.DatabaseControllerService.AutoTesti Eka();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Eka", ReplyAction="http://tempuri.org/IService1/EkaResponse")]
        System.Threading.Tasks.Task<Auto.DatabaseControllerService.AutoTesti> EkaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Seuraava", ReplyAction="http://tempuri.org/IService1/SeuraavaResponse")]
        Auto.DatabaseControllerService.AutoTesti Seuraava(int NykyinenID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Seuraava", ReplyAction="http://tempuri.org/IService1/SeuraavaResponse")]
        System.Threading.Tasks.Task<Auto.DatabaseControllerService.AutoTesti> SeuraavaAsync(int NykyinenID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Edellinen", ReplyAction="http://tempuri.org/IService1/EdellinenResponse")]
        Auto.DatabaseControllerService.AutoTesti Edellinen(int NykyinenID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Edellinen", ReplyAction="http://tempuri.org/IService1/EdellinenResponse")]
        System.Threading.Tasks.Task<Auto.DatabaseControllerService.AutoTesti> EdellinenAsync(int NykyinenID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Vika", ReplyAction="http://tempuri.org/IService1/VikaResponse")]
        Auto.DatabaseControllerService.AutoTesti Vika();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Vika", ReplyAction="http://tempuri.org/IService1/VikaResponse")]
        System.Threading.Tasks.Task<Auto.DatabaseControllerService.AutoTesti> VikaAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Auto.DatabaseControllerService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Auto.DatabaseControllerService.IService1>, Auto.DatabaseControllerService.IService1 {
        
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
        
        public bool connectDatabase() {
            return base.Channel.connectDatabase();
        }
        
        public System.Threading.Tasks.Task<bool> connectDatabaseAsync() {
            return base.Channel.connectDatabaseAsync();
        }
        
        public bool saveAutoIntoDatabase(Auto.DatabaseControllerService.AutoTesti newAuto) {
            return base.Channel.saveAutoIntoDatabase(newAuto);
        }
        
        public System.Threading.Tasks.Task<bool> saveAutoIntoDatabaseAsync(Auto.DatabaseControllerService.AutoTesti newAuto) {
            return base.Channel.saveAutoIntoDatabaseAsync(newAuto);
        }
        
        public System.Collections.Generic.List<Auto.DatabaseControllerService.AutonMerkki> getAllAutoMakersFromDatabase() {
            return base.Channel.getAllAutoMakersFromDatabase();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Auto.DatabaseControllerService.AutonMerkki>> getAllAutoMakersFromDatabaseAsync() {
            return base.Channel.getAllAutoMakersFromDatabaseAsync();
        }
        
        public System.Collections.Generic.List<Auto.DatabaseControllerService.AutonMalli> getAutoModelsByMakerId(int makerId) {
            return base.Channel.getAutoModelsByMakerId(makerId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Auto.DatabaseControllerService.AutonMalli>> getAutoModelsByMakerIdAsync(int makerId) {
            return base.Channel.getAutoModelsByMakerIdAsync(makerId);
        }
        
        public System.Collections.Generic.List<Auto.DatabaseControllerService.Polttoaine> getCarFuel() {
            return base.Channel.getCarFuel();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Auto.DatabaseControllerService.Polttoaine>> getCarFuelAsync() {
            return base.Channel.getCarFuelAsync();
        }
        
        public System.Collections.Generic.List<Auto.DatabaseControllerService.Vari> getColor() {
            return base.Channel.getColor();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Auto.DatabaseControllerService.Vari>> getColorAsync() {
            return base.Channel.getColorAsync();
        }
        
        public Auto.DatabaseControllerService.AutoTesti Eka() {
            return base.Channel.Eka();
        }
        
        public System.Threading.Tasks.Task<Auto.DatabaseControllerService.AutoTesti> EkaAsync() {
            return base.Channel.EkaAsync();
        }
        
        public Auto.DatabaseControllerService.AutoTesti Seuraava(int NykyinenID) {
            return base.Channel.Seuraava(NykyinenID);
        }
        
        public System.Threading.Tasks.Task<Auto.DatabaseControllerService.AutoTesti> SeuraavaAsync(int NykyinenID) {
            return base.Channel.SeuraavaAsync(NykyinenID);
        }
        
        public Auto.DatabaseControllerService.AutoTesti Edellinen(int NykyinenID) {
            return base.Channel.Edellinen(NykyinenID);
        }
        
        public System.Threading.Tasks.Task<Auto.DatabaseControllerService.AutoTesti> EdellinenAsync(int NykyinenID) {
            return base.Channel.EdellinenAsync(NykyinenID);
        }
        
        public Auto.DatabaseControllerService.AutoTesti Vika() {
            return base.Channel.Vika();
        }
        
        public System.Threading.Tasks.Task<Auto.DatabaseControllerService.AutoTesti> VikaAsync() {
            return base.Channel.VikaAsync();
        }
    }
}