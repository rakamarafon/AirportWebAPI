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

_Departures_
* Get departures list (GET): /api/Departures
* Get departures by id (GET): /api/Departures/:id
* Create new departure (POST): /api/Departures
                           Body: {                                  
                                  flightNumber: string,
                                  departureTime: string,
                                  crew: int,
                                  aircraft: int
                                 }
* Update departures (PUT) /api/Departures/:id    
                            Body: {
                                   flightNumber: string,
                                   departureTime: string,
                                   crew: int,
                                   aircraft: int
                                 }
* Delete departures by id (DELETE): /api/Departures/:id 

_Stewardesses_
* Get stewardesses list (GET): /api/Stewardesses
* Get stewardesses by id (GET): /api/Stewardesses/:id
* Create new stewardesses (POST): /api/Stewardesses
                           Body: {                                  
                                  firstName: string,
                                  secondName: string,
                                  birthDate: string
                                 }
* Update stewardesses (PUT) /api/Stewardesses/:id    
                            Body: {
                                  firstName: string,
                                  secondName: string,
                                  birthDate: string
                                 }
* Delete stewardesses by id (DELETE): /api/Stewardesses/:id 

_Pilots_
* Get pilots list (GET): /api/Pilots
* Get pilot by id (GET): /api/Pilots/:id
* Create new pilot (POST): /api/Pilots
                           Body: {                                  
                                  firstName: string,
                                  secondName: string,
                                  birthDate: string,
                                  experiance: int
                                 }
* Update pilot (PUT) /api/Pilots/:id    
                            Body: {
                                  firstName: string,
                                  secondName: string,
                                  birthDate: string,
                                  experiance: int
                                 }
* Delete pilot by id (DELETE): /api/Pilots/:id 

_Crews_
* Get crews list (GET): /api/Crews
* Get crew by id (GET): /api/Crews/:id
* Create new crew (POST): /api/Crews
                           Body: {                                  
                                  pilotId: int,
                                  stewardesses[id: int]
                                 }
* Update crew (PUT) /api/Crews/:id    
                            Body: {
                                  pilot: int,
                                  stewardesses[id: int]
                                 }
* Delete crew by id (DELETE): /api/Crews/:id 

_Aircrafts_
* Get aircrafts list (GET): /api/Aircrafts
* Get aircraft by id (GET): /api/Aircrafts/:id
* Create new aircraft (POST): /api/Aircrafts
                           Body: {                                  
                                  name: string,
                                  airType: int,
                                  releaseDate: string,
                                  lifeTime: string
                                 }
* Update aircraft (PUT) /api/Aircrafts/:id    
                            Body: {
                                  name: string,
                                  airType: int,
                                  releaseDate: string,
                                  lifeTime: string
                                 }
* Delete aircraft by id (DELETE): /api/Aircrafts/:id 
