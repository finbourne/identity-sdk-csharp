# Finbourne.Identity.Sdk.Model.LogGeographicalContext
Represents a LogGeographicalContext resource in the Okta API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**City** | **string** |  | [optional] 
**State** | **string** |  | [optional] 
**Country** | **string** |  | [optional] 
**PostalCode** | **string** |  | [optional] 
**Geolocation** | [**LogGeolocation**](LogGeolocation.md) |  | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string city = "example city";
string state = "example state";
string country = "example country";
string postalCode = "example postalCode";
LogGeolocation? geolocation = new LogGeolocation();


LogGeographicalContext logGeographicalContextInstance = new LogGeographicalContext(
    city: city,
    state: state,
    country: country,
    postalCode: postalCode,
    geolocation: geolocation);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
