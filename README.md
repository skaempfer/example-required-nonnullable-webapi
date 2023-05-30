# Force a required predicate on model properties with default values

## Problem statement

Making a model property 'required' when it has a default value (value types) can be tricky because a model object's property will always
have a value no matter if the data from the request to be bound to the model object contains a value for said property or not. 

## Solution shown here

The solution shown here makes use of the `Newtonsoft.Json` serializer's ability to mark an expected property as required before it
is even bound to the C# object model. With this approach you can check for the availability of non-null data types during model binding.

## How to start

- Execute `dotnet run` inside the project directory
- Execute `Invoke-WebRequest -Uri http://localhost:5137/weatherforecast -Method Post -ContentType 'application/json' -Body '{}'`
- You will receive a validation error on a value-type model property
- Execute `Invoke-WebRequest -Uri http://localhost:5137/weatherforecast -Method Post -ContentType 'application/json' -Body '{"temperatureC": 25}'`
- You will receive a 204 NoContent result since validation has passed