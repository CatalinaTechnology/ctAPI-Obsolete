ctDynamicsSL RESTful API Overview
=======
ctDynamicsSL has th ability to be accessed via RESTful API calls.

# Prerequisites

To start with ctDynamicsSL, you must have the following: 

* Have a license to ctDynamicsSL web services
* Have the web services installed and configured to integrate to your Dynamics SL ERP system
* APIKey:  This is an application API key your ctDynamicsSL administrator will give you
* Secret Key:  This is a secret pass code your ctDynamicsSL administrator will give you

## Accounts Receivable Web Service
### Authentication for ctDynamicsSL requires the following
You must pass a custom HTTP Header called Authentication to the web REST API service.  This is in the form of the following information:


- Create a string with the following information:  APIKey + ',' + SecretKey
- Take the output of the that string and a Base64 string.

And example in c# to create such a string is as follows:

	System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(APIKey + "," + SecretKey));

You would then pass that as an HTTP Header called "Authorization".  An example in c# would be as following:


    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://myServer/myEndpoint);
    request.Method = "POST";
    request.ContentType = "application/json";
	request.Headers.Add("Authorization", "[MyBase64AuthString]");

Looking at the code example, you would replace the *[MyBase64AuthString]* with your authorization string.  You would also change the URL in the WebRequest.Create() to match the endpoint you are accessing.



## Payment Entry
### Managing Screens, Batches, ARDoc, and ARTran
#### Create a payment entry
Payment Entry requires several steps to create a payment entry:

1. create the screen object
2. update the batch and ARDoc objects for overrides you want to make
3. create ARTran records
4. Save the screen back to the web service
 

#### Retrieve an existing payment entry screen
* **Description**: Retrieves an existing payment entry screen based on the batNbr passed
* **Endpoint**: /api/accountsReceivable/paymentEntry/screen/{batNbr}
* **HTTP Method**: ``GET``
* **Request PayLoad**: No Payload
* **Response PayLoad**: ``PaymentEntryScreen`` object returned that matches the batNbr passed
* **Online Help**: [Help]()

#### Get new payment entry screen from a template
* **Description**: Creates a new payment entry screen and fills in defaults.  You can pass a template screen object for initial values.
* **Endpoint**: /api/accountsReceivable/paymentEntry/templates/getNewScreen
* **HTTP Method**: ``POST``
* **Request PayLoad**: ``PaymentEntryScreen``
* **Response PayLoad**: ``PaymentEntryScreen`` object returned with defaults created
* **Online Help**: [Help]()

#### Get new ARTran from a template
* **Description**: Will create an ARTran object, filling in defaults of fields not passed in the template.
* **Endpoint**: /api/accountsReceivable/paymentEntry/templates/getNewARTran
* **HTTP Method**: ``POST``
* **Request PayLoad**: ``ARTran``
* **Response PayLoad**: ``ARTran`` object returned with defaults created
* **Online Help**: [Help]()


#### Save a new payment entry screen
* **Description**: This will create a new payment entry screen in SL based on the screen passed.  Defaults will be set on fields not sent. 
* **Endpoint**: /api/accountsReceivable/paymentEntry/screen
* **HTTP Method**: ``POST``
* **Request PayLoad**: ``PaymentEntryScreen``
* **Response PayLoad**: ``PaymentEntryScreen`` object returned with defaults created
* **Online Help**: [Help]()


#### Update an existing payment entry Screen
* **Description**: This will update an existing payment entry screen based on the object passed 
* **Endpoint**: /api/accountsReceivable/paymentEntry/screen
* **HTTP Method**: ``PUT``
* **Request PayLoad**: ``PaymentEntryScreen``
* **Response PayLoad**: ``PaymentEntryScreen`` object returned with defaults created
* **Online Help**: [Help]()

### PV Lookups
ctDynamicsSL web services also allow you to do your typical PV Lookups for certain DynamicsSL fields.
#### Retrieve projects
* **Description**: Retrieve all projects matching the partial projectID search.  The projectID is automatically wildcarded on both the left and right of the string you pass.
* **Endpoint**: /api/accountsReceivable/paymentEntry/pvLookup/projects?projectID={projectID}
* **HTTP Method**: ``GET``
* **Request PayLoad**: No Payload
* **Response PayLoad**: Collection of [PJPROJ]() objects.
* **Online Help**: [Help]()


# HTTP Request PayLoads

## PaymentEntryScreen 
This is used to retrieve and set the payment entry screen in Dynamics SL AR.

| Attribute                  | Description    | 
| -------------------------- | :------------- | 
| Batch                     | Batch(myBatch) | 

## Batch
Description for Batch

| Attribute                  | Description    | 
| -------------------------- | :------------- | 
| BatNbr                     | This is the batch number for the batch | 

