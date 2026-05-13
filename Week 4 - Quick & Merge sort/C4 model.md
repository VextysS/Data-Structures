\-systeem context diagram: verschillende blocken. eigen system, users, en externe



\-controller diagram: in u systeem, hoe je het opdeeld, vb. controller frontend-end

Welke controller(service-layer, etc) welke connectie maakt (vb. externe 





Systeem diagram

Frontend (Angular)

* Alleen UI
* geen spellogica
* geen validatie



Backend Core (NestJS)

* spelregels
* plugin-orkestratie
* validatie



Database:

* users
* progress



Plugin repo:

* level logic
* configs



\-Waarom angular \& NestJS. frameworks dat alle leden kennen, zelfde kern porgrameertaal (typescript) voor maintainability

\-Code execution service (VM) In een aparte container om te voorkomen dat bugs de core laten crashen \& veiligheid te verzekeren (Fault Tolerance)

