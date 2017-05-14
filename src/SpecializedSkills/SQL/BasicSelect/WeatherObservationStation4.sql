-- https://www.hackerrank.com/challenges/weather-observation-station-4

SELECT 
    (SELECT Count(City) FROM Station) - (SELECT Count(DISTINCT City) FROM Station) AS Diff