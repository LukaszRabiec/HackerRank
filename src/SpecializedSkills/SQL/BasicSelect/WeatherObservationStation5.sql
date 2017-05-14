SELECT City FROM Station
-- https://www.hackerrank.com/challenges/weather-observation-station-5

SELECT TOP 1 City, len(City) FROM Station
ORDER BY len(City), City ASC

SELECT TOP 1 City, len(City) FROM Station
ORDER BY len(City) DESC, City ASC 