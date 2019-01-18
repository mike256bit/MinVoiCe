# MinVoiCe
MinVoiCe is a personally tailored, bare-bones invoicing software built in C#, which has simple project and client management, minimal worktime entry UI, and easy invoice generation.


#1.15.2019
Adding table notes from initial mapping (these are all objects and DB tables):

## invoice
* id
* user_id
* start_date
* end_date
* list<worktime_id>
* project_id

## payments_received
* id
* date
* amount
* invoice_id (may need to change many-to-many?)
* tax_withhold_percent

## worktime
* id
* hours
* date
* project_id
* user_id
* description

## project
* id
* name
* rate
* client_id 

## client
* id
* name
* point_of_contact
* phone
* email
* address_street
* address_cityStateZip

## user
* id
* name
* title
* phone
* email
* address_street
* address_cityStateZip