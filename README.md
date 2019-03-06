# MinVoiCe
MinVoiCe is a personally tailored, bare-bones invoicing software built in C#, which has simple project and client management, minimal worktime entry UI, and easy invoice generation.


## 3.6.2019
MinVoiCe is finally at a better-than-MVP state, with decent UI, look and feel. There are many features yet to add, but as a base product it demonstrates my one main goal -- simplifying the invoicing process as much as possible for the way I work and the way I enter my time. 

## 2.5.2019
Adding POCOs for each model (project, client, etc) prior to migrating to a persistent database. DBContext already exists but is not being used for now. Currently treating the project like CheeseMVC to build the basics and get some really simple navigation. 

## 1.22.2019
Reconsidering the hour entry for weekly instead of daily. Have dates preloaded, access via dropdown. No current need for granular daily entry. 

## 1.15.2019
Adding table notes from initial mapping (these are all objects and DB tables):

### invoice
* id
* user_id
* start_date
* end_date
* list<worktime_id>
* project_id

### payments_received
* id
* date
* amount
* invoice_id (may need to change many-to-many?)
* tax_withhold_percent

### worktime
* id
* hours
* date
* project_id
* user_id
* description

### project
* id
* name
* rate
* client_id 

### client
* id
* name
* point_of_contact
* phone
* email
* address_street
* address_cityStateZip

### user
* id
* name
* title
* phone
* email
* address_street
* address_cityStateZip