# Seamless Address Autocomplete With Google Places

Elevate your Umbraco Forms experience with this Autocomplete fieldtype that harnesses the capabilities of Google Places API.
Streamline address entry for users by offering intelligent autocomplete suggestions and effortless autofill functionality.

## Key Features

* **Address Autocomplete**: Provide users with real-time address suggestions as they type.
* **Autofill**: Automatically populate address fields like street, house number and city with the selected address.
* **Customizable**: Configure the fields to suit your needs by setting the country, language, and other options.
* **Intuitive User Experience**: Provide a smooth and familiar address entry process, minimizing user frustration and reducing form abandonment rates.
* **Easy Installation and Setup**: Straightforward integration into your Umbraco Forms with minimal configuration required.

## Installation

1. Install Kodblue.Autocomplet.Address via NuGet Package Manager.
3. Add your Google Places API key to your appsettings.json file with the following name: KodblueAutocompleteAddress:GooglePlacesApiKey.
3. Add the `Autocomplete Address` field to your form.

### Address fields
The Google Places Autocomplete field will automatically populate the following fields:

* Street: You don't need to add a separate field for the street, when using the Autocomplete Address field, there will be a hidden textfield where we autofill the street.
* House number: Add a field for house number with alias: houseNumber
* Apartment / suite: Add a field for apartment / suite with alias: apartment
* Sublocality: Add a field for sublocality with alias: sublocality
* City: Add a field for city with alias: city
* Zip code: Add a field for zip code with alias: zipCode
* State: Add a field for state with alias: state
* Country: Add a field for country with alias: country

It is not required to add all the fields, you can add only the fields you need, but it is important to add the fields with the correct alias, otherwise the field will not be populated.

### Alternative Google Places API Key Configuration
The package checks if there is a API key in the appsettings.json file, if there is one it will place the Google Places script directly above the field. 
If there is no key, the package will not add the script to the html. 

So if you would like to add the Google Places script to the head section of the website, you can do this manually.

## Screenshots

![Front-end](https://i.imgur.com/lpKNz9s.gif)

![Back-end](https://i.imgur.com/x8cAJJg.png)