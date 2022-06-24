# Scripts to run intrasystems in container

run command in this directory:


		docker-compose up


wait until wildfly and database starts.


build intralogin code 

cd backend and run database migration with command


	mvn flyway:migrate


deploy ear with command 
	
	
	./docker/deploy_ear.sh




