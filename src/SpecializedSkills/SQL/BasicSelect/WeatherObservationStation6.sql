-- https://www.hackerrank.com/challenges/weather-observation-station-6

SELECT City FROM Station 
WHERE Left(City, 1) LIKE '%[aeiou]%'