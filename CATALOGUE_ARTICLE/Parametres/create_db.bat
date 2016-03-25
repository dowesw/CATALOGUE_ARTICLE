 
@ECHO OFF
echo rem -------------------------------------------------
echo rem  Creation base de donnees catalogue articles
echo rem -------------------------------------------------
 

SET nom_serveur=localhost
SET nom_user=postgres
SET port_def=5432
SET PGPASSWORD=yves1910/
SET location_db = "C:\Users\Lymytz\Google Drive\Mes projets\Catalogue Article\CATALOGUE_ARTICLE\CATALOGUE_ARTICLE\CATALOGUE_ARTICLE\bin\Debug\Parametres"
SET location_bin = "C:\Program Files\PostgresSQL\9.2\bin"

echo rem %location_db%

cd %location_bin%
createdb -h %nom_serveur% -p %port_def% -U %nom_user% catalogue_article
psql -h %nom_serveur% -p %port_def% -U %nom_user%  catalogue_article < %location_db%db.sql