SELECT countries.name
FROM countries
JOIN languages ON countries.id =languages.country_id
WHERE languages="slovene"

