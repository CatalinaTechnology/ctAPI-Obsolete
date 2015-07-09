ctDynamicsSL RESTful API Overview
=======
ctDynamicsSL has th ability to be accessed via RESTful API calls.

# Prerequisites

To start with ctDynamicsSL, you must 
* Have a license to ctDynamicsSL web services
* Have the web services installed and configured to integrate to your Dynamics SL ERP system

Accounts Receivable Web Service
=======
### Authentication for ctDynamicsSL requires the following
* APIKey
* Secret Key


### Create a Payment Entry
Payment Entry requires several steps to create a payment entry:
1. create the screen object
2. update the batch and ARDoc objects for overrides you want to make
3. create ARTran records
4. Save the screen back to the web service
 

#### Get new Payment Entry Screen from a template
* **Description**: Creates a new Payment Entry screen and fills in defaults.  You can pass a template screen object for initial values.
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


#### Save a new Payment Entry Screen
* **Description**: This will create a new payment entry screen in SL based on the screen passed.  Defaults will be set on fields not sent. 
* **Endpoint**: /api/accountsReceivable/paymentEntry/screen
* **HTTP Method**: ``POST``
* **Request PayLoad**: ``PaymentEntryScreen``
* **Response PayLoad**: ``PaymentEntryScreen`` object returned with defaults created
* **Online Help**: [Help]()


#### Update an existing Payment Entry Screen
* **Description**: This will update an existing Payment Entry screen based on the object passed 
* **Endpoint**: /api/accountsReceivable/paymentEntry/screen
* **HTTP Method**: ``PUT``
* **Request PayLoad**: ``PaymentEntryScreen``
* **Response PayLoad**: ``PaymentEntryScreen`` object returned with defaults created
* **Online Help**: [Help]()

# HTTP Request PayLoads

## PaymentEntryScreen 
This is used to retrieve and set the Payment Entry screen in Dynamics SL AR.

| Attribute                  | Description    | 
| -------------------------- | :------------- | 
| Batch                     | Batch(myBatch) | 

## Batch
Description for Batch

| Attribute                  | Description    | 
| -------------------------- | :------------- | 
| BatNbr                     | This is the batch number for the batch | 

