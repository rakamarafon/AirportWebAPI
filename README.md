# AirportWebAPI
_Flights_
* Get flights list (GET): /api/Flights
* Get flight by id (GET): /api/Flights/:id
* Create new flight (POST): /api/Flights
                           Body: {
                                  number: string,
                                  departurePoint: int,
                                  departureTime: string,
                                  destinationPoint: int,
                                  destinationTime: string,
                                  tiskets: [tisket: int]
                                 }
* Update flight (PUT) /api/Flights/:id    
                            Body: {
                                  number: string,
                                  departurePoint: int,
                                  departureTime: string,
                                  destinationPoint: int,
                                  destinationTime: string,
                                  tiskets: [tisket: int]
                                 }
* Delete flight by id (DELETE) /api/Flights/:id

                                 
_Tickets_
* Get tickets list (GET): /api/Tickets
* Get ticket by id (GET): /api/Tickets/:id
* Create new flight (POST): /api/Tickets
                           Body: {
                                  price: double,
                                  flightNumber: string
                                 }
* Update flight (PUT) /api/Tickets/:id    
                            Body: {
                                  price: double,
                                  flightNumber: string
                                 }
* Delete ticket by id (DELETE): /api/Tickets/:id                                 
