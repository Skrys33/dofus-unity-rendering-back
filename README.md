# dofus-unity-rendering-back

# Loading process of data into the database
1- Export the MonsterRoot bundle to a JSON file. (ex: with UABEA)

2- Use jsonCleaner.py to remove Array level.

3- Run Docker Compose : docker compose up

4- Update the database structure from Package Manager Console : EntityFrameworkCore\update-database

5- Use DataLoaderService.LoadDataFromJSon to parse JSON file & push data to the database.

