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
 

#### Get new Payment Entry Screen
* **Description**: This is used to create payment entries.  There are several steps to do this
* **Endpoint**: /api/accountsReceivable/paymentEntry/templates/getNewScreen
* **HTTP Method**: ``POST``
* **Request PayLoad**: ``Screen``
* **Response PayLoad**: ``Screen`` object returned with defaults created
* **Online Help**: [Help]()
