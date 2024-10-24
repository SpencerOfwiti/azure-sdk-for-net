// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// AppServiceDomain.
/// </summary>
public partial class AppServiceDomain : ProvisionableResource
{
    /// <summary>
    /// Name of the domain.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Gets or sets the auth code.
    /// </summary>
    public BicepValue<string> AuthCode { get => _authCode; set => _authCode.Assign(value); }
    private readonly BicepValue<string> _authCode;

    /// <summary>
    /// Legal agreement consent.
    /// </summary>
    public BicepValue<DomainPurchaseConsent> Consent { get => _consent; set => _consent.Assign(value); }
    private readonly BicepValue<DomainPurchaseConsent> _consent;

    /// <summary>
    /// Administrative contact.
    /// </summary>
    public BicepValue<RegistrationContactInfo> ContactAdmin { get => _contactAdmin; set => _contactAdmin.Assign(value); }
    private readonly BicepValue<RegistrationContactInfo> _contactAdmin;

    /// <summary>
    /// Billing contact.
    /// </summary>
    public BicepValue<RegistrationContactInfo> ContactBilling { get => _contactBilling; set => _contactBilling.Assign(value); }
    private readonly BicepValue<RegistrationContactInfo> _contactBilling;

    /// <summary>
    /// Registrant contact.
    /// </summary>
    public BicepValue<RegistrationContactInfo> ContactRegistrant { get => _contactRegistrant; set => _contactRegistrant.Assign(value); }
    private readonly BicepValue<RegistrationContactInfo> _contactRegistrant;

    /// <summary>
    /// Technical contact.
    /// </summary>
    public BicepValue<RegistrationContactInfo> ContactTech { get => _contactTech; set => _contactTech.Assign(value); }
    private readonly BicepValue<RegistrationContactInfo> _contactTech;

    /// <summary>
    /// Current DNS type.
    /// </summary>
    public BicepValue<AppServiceDnsType> DnsType { get => _dnsType; set => _dnsType.Assign(value); }
    private readonly BicepValue<AppServiceDnsType> _dnsType;

    /// <summary>
    /// Azure DNS Zone to use.
    /// </summary>
    public BicepValue<string> DnsZoneId { get => _dnsZoneId; set => _dnsZoneId.Assign(value); }
    private readonly BicepValue<string> _dnsZoneId;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if the domain should be automatically
    /// renewed; otherwise, &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsAutoRenew { get => _isAutoRenew; set => _isAutoRenew.Assign(value); }
    private readonly BicepValue<bool> _isAutoRenew;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if domain privacy is enabled for this
    /// domain; otherwise, &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsDomainPrivacyEnabled { get => _isDomainPrivacyEnabled; set => _isDomainPrivacyEnabled.Assign(value); }
    private readonly BicepValue<bool> _isDomainPrivacyEnabled;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Target DNS type (would be used for migration).
    /// </summary>
    public BicepValue<AppServiceDnsType> TargetDnsType { get => _targetDnsType; set => _targetDnsType.Assign(value); }
    private readonly BicepValue<AppServiceDnsType> _targetDnsType;

    /// <summary>
    /// Domain creation timestamp.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn { get => _createdOn; }
    private readonly BicepValue<DateTimeOffset> _createdOn;

    /// <summary>
    /// Reasons why domain is not renewable.
    /// </summary>
    public BicepList<DomainNotRenewableReason> DomainNotRenewableReasons { get => _domainNotRenewableReasons; }
    private readonly BicepList<DomainNotRenewableReason> _domainNotRenewableReasons;

    /// <summary>
    /// Domain expiration timestamp.
    /// </summary>
    public BicepValue<DateTimeOffset> ExpireOn { get => _expireOn; }
    private readonly BicepValue<DateTimeOffset> _expireOn;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if Azure can assign this domain to App
    /// Service apps; otherwise, &lt;code&gt;false&lt;/code&gt;. This value
    /// will be &lt;code&gt;true&lt;/code&gt; if domain registration status is
    /// active and              it is hosted on name servers Azure has
    /// programmatic access to.
    /// </summary>
    public BicepValue<bool> IsDnsRecordManagementReady { get => _isDnsRecordManagementReady; }
    private readonly BicepValue<bool> _isDnsRecordManagementReady;

    /// <summary>
    /// Timestamp when the domain was renewed last time.
    /// </summary>
    public BicepValue<DateTimeOffset> LastRenewedOn { get => _lastRenewedOn; }
    private readonly BicepValue<DateTimeOffset> _lastRenewedOn;

    /// <summary>
    /// All hostnames derived from the domain and assigned to Azure resources.
    /// </summary>
    public BicepList<AppServiceHostName> ManagedHostNames { get => _managedHostNames; }
    private readonly BicepList<AppServiceHostName> _managedHostNames;

    /// <summary>
    /// Name servers.
    /// </summary>
    public BicepList<string> NameServers { get => _nameServers; }
    private readonly BicepList<string> _nameServers;

    /// <summary>
    /// Domain provisioning state.
    /// </summary>
    public BicepValue<ProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<ProvisioningState> _provisioningState;

    /// <summary>
    /// Domain registration status.
    /// </summary>
    public BicepValue<AppServiceDomainStatus> RegistrationStatus { get => _registrationStatus; }
    private readonly BicepValue<AppServiceDomainStatus> _registrationStatus;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new AppServiceDomain.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the AppServiceDomain resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AppServiceDomain.</param>
    public AppServiceDomain(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.DomainRegistration/domains", resourceVersion ?? "2024-04-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _authCode = BicepValue<string>.DefineProperty(this, "AuthCode", ["properties", "authCode"]);
        _consent = BicepValue<DomainPurchaseConsent>.DefineProperty(this, "Consent", ["properties", "consent"]);
        _contactAdmin = BicepValue<RegistrationContactInfo>.DefineProperty(this, "ContactAdmin", ["properties", "contactAdmin"]);
        _contactBilling = BicepValue<RegistrationContactInfo>.DefineProperty(this, "ContactBilling", ["properties", "contactBilling"]);
        _contactRegistrant = BicepValue<RegistrationContactInfo>.DefineProperty(this, "ContactRegistrant", ["properties", "contactRegistrant"]);
        _contactTech = BicepValue<RegistrationContactInfo>.DefineProperty(this, "ContactTech", ["properties", "contactTech"]);
        _dnsType = BicepValue<AppServiceDnsType>.DefineProperty(this, "DnsType", ["properties", "dnsType"]);
        _dnsZoneId = BicepValue<string>.DefineProperty(this, "DnsZoneId", ["properties", "dnsZoneId"]);
        _isAutoRenew = BicepValue<bool>.DefineProperty(this, "IsAutoRenew", ["properties", "autoRenew"]);
        _isDomainPrivacyEnabled = BicepValue<bool>.DefineProperty(this, "IsDomainPrivacyEnabled", ["properties", "privacy"]);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _targetDnsType = BicepValue<AppServiceDnsType>.DefineProperty(this, "TargetDnsType", ["properties", "targetDnsType"]);
        _createdOn = BicepValue<DateTimeOffset>.DefineProperty(this, "CreatedOn", ["properties", "createdTime"], isOutput: true);
        _domainNotRenewableReasons = BicepList<DomainNotRenewableReason>.DefineProperty(this, "DomainNotRenewableReasons", ["properties", "domainNotRenewableReasons"], isOutput: true);
        _expireOn = BicepValue<DateTimeOffset>.DefineProperty(this, "ExpireOn", ["properties", "expirationTime"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _isDnsRecordManagementReady = BicepValue<bool>.DefineProperty(this, "IsDnsRecordManagementReady", ["properties", "readyForDnsRecordManagement"], isOutput: true);
        _lastRenewedOn = BicepValue<DateTimeOffset>.DefineProperty(this, "LastRenewedOn", ["properties", "lastRenewedTime"], isOutput: true);
        _managedHostNames = BicepList<AppServiceHostName>.DefineProperty(this, "ManagedHostNames", ["properties", "managedHostNames"], isOutput: true);
        _nameServers = BicepList<string>.DefineProperty(this, "NameServers", ["properties", "nameServers"], isOutput: true);
        _provisioningState = BicepValue<ProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _registrationStatus = BicepValue<AppServiceDomainStatus>.DefineProperty(this, "RegistrationStatus", ["properties", "registrationStatus"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported AppServiceDomain resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-04-01.
        /// </summary>
        public static readonly string V2024_04_01 = "2024-04-01";

        /// <summary>
        /// 2023-12-01.
        /// </summary>
        public static readonly string V2023_12_01 = "2023-12-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";

        /// <summary>
        /// 2021-03-01.
        /// </summary>
        public static readonly string V2021_03_01 = "2021-03-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2021-01-15.
        /// </summary>
        public static readonly string V2021_01_15 = "2021-01-15";

        /// <summary>
        /// 2021-01-01.
        /// </summary>
        public static readonly string V2021_01_01 = "2021-01-01";

        /// <summary>
        /// 2020-12-01.
        /// </summary>
        public static readonly string V2020_12_01 = "2020-12-01";

        /// <summary>
        /// 2020-10-01.
        /// </summary>
        public static readonly string V2020_10_01 = "2020-10-01";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";

        /// <summary>
        /// 2018-02-01.
        /// </summary>
        public static readonly string V2018_02_01 = "2018-02-01";

        /// <summary>
        /// 2015-04-01.
        /// </summary>
        public static readonly string V2015_04_01 = "2015-04-01";

        /// <summary>
        /// 2015-02-01.
        /// </summary>
        public static readonly string V2015_02_01 = "2015-02-01";
    }

    /// <summary>
    /// Creates a reference to an existing AppServiceDomain.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the AppServiceDomain resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AppServiceDomain.</param>
    /// <returns>The existing AppServiceDomain resource.</returns>
    public static AppServiceDomain FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
