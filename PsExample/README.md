# Pub Sub pattern in Net using  C# Channel 
this is an example service to show the ability of C# channel in Pub Sub Pattern 
## Preparations
Clone with https://gitlab.okala.com/okala/backend/microservices/pushnotification.git

## Guids




```c#
var myHeaders = new Headers();
myHeaders.append("Authorization", "Bearer eyJhbGciOiJSUzI1NiIsImtpZCI6IjEzRjRFNUExQ0NGNUU4NjRBQTI3MzgyMkM3OENERTIxQTM4MkRBOENSUzI1NiIsInR5cCI6ImF0K2p3dCIsIng1dCI6IkVfVGxvY3oxNkdTcUp6Z2l4NHplSWFPQzJvdyJ9.eyJuYmYiOjE3MDEzMzc5NjQsImV4cCI6MTcwMTM4MTE2NCwiaXNzIjoiaHR0cDovL2NlcmJlcnVzLm1lbWJlcnNoaXAiLCJjbGllbnRfaWQiOiJyb3AiLCJzdWIiOiI3NWE3Y2E1MS1jYTdkLTQwZDYtOGY1ZS0wYWVmY2JkYmExNmEiLCJhdXRoX3RpbWUiOjE3MDEzMzc5NjQsImlkcCI6ImxvY2FsIiwidW5pcXVlX25hbWUiOiIwOTM1MTEyODYyOCIsInVzZXJJZCI6IjYzMDMwMCIsIm5hbWUiOiLYs9i524zYryDZhduM2LHYotiu2YjYsdmE2YgiLCJyb2xlIjoiQWRtaW4iLCJqdGkiOiI5QjY4NDUzNDA1NTQ5NkY2M0U3REI0OTVENUY2MzkyQyIsImlhdCI6MTcwMTMzNzk2NCwic2NvcGUiOlsiYmFja29mZmljZSIsImVtYWlsIiwib3BlbmlkIiwicGhvbmUiLCJwcm9maWxlIiwib2ZmbGluZV9hY2Nlc3MiXSwiYW1yIjpbInB3ZCJdfQ.hPzmS8-kteJbIUEx2MXCvRuTIsrczB87alHGKBatjNev8z__9ryvdVkYtWzDhAWFr5sC1HNUNhG-YSa1crkVF3AcRov4nvbnBW-S198EzbnRcM2RxIhmBuXFYEMzr1M1nM1RF_qIrsNUtq80qkB6FwSxWHhDS9AC08RTz9eSDBEjo_FE_omey5CMvyJM7nqRwOiWW_lBxRq-j0U3kHTKikvhh9Fi1UB0jv21dk1VEAD8vzbT_8oPSkOmc8wJFchJe_g0QgGzs6r5suqOFZ_3RQ3TtqFkoAwu0GQWJSLUKdEjvxLLJccBjkbElcmloSqbP3MKdiBQ-lWitdJkQr5x_Q");
myHeaders.append("Content-Type", "application/json");

var raw = JSON.stringify({
  "filter": "اُما",
  "orderBy": "string",
  "parentId": 0
});

var requestOptions = {
  method: 'POST',
  headers: myHeaders,
  body: raw,
  redirect: 'follow'
};

fetch("https://bff.okala.com/api/discount/v1/discounttypes/lookup", requestOptions)
  .then(response => response.text())
  .then(result => console.log(result))
  .catch(error => console.log('error', error));
```