
CREATE TABLE workitems (
	wks_id serial primary key NOT NULL ,
	numref varchar(16) unique not null,
	title varchar(64) not null,
	assignedto varchar(64) not null,
	area varchar(64) not null,
	reason varchar(128),
	created timestamp not null default current_timestamp
);


create or replace function usp_createworkitem(out nref varchar,varchar,varchar,varchar,varchar,out creationDate timestamp) 
 as '  
 declare
 id int;
begin
	id := nextval(''workitems_wks_id_seq'');
	Insert into workitems(wks_id,numref,title,assignedto,area,reason,created)
	values(id,createrefnum(id),$2,$3,$4,$5,now());
	select into nref numref from workitems where wks_id = id;
	select into creationDate created from workitems where wks_id = id;
end;' language 'plpgsql';

  CREATE OR REPLACE FUNCTION createrefnum(id numeric)
  RETURNS character varying AS
 '
DECLARE
	refnum 	  varchar;
	rndnum    numeric;
BEGIN
	rndnum := CAST(random() * DATE_PART(''year'',CURRENT_DATE) AS int2);
	refnum := cast(rndnum as varchar) || cast(id as varchar);
	RETURN refnum;
END;'
  LANGUAGE plpgsql VOLATILE
  