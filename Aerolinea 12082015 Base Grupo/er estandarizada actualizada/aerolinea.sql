--
-- ER/Studio 8.0 SQL Code Generation
-- Company :      umg
-- Project :      entidad relacion aerolinea.dm1
-- Author :       Jose
--
-- Date Created : Wednesday, August 12, 2015 17:25:24
-- Target DBMS : MySQL 5.x
--

-- 
-- TABLE: MaAVION 
--

CREATE TABLE MaAVION(
    ncodavion          DECIMAL(10, 0)    NOT NULL,
    vaerolinea         VARCHAR(20),
    vmodelo            VARCHAR(20),
    vmatricula         VARCHAR(20),
    vdisponibilidad    VARCHAR(20),
    ncodtipoavion      DECIMAL(10, 0),
    PRIMARY KEY (ncodavion)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaPAGO 
--

CREATE TABLE MaPAGO(
    ncodpago             DECIMAL(10, 0)    NOT NULL,
    ntotal               DECIMAL(10, 0),
    nnotarjeta           DECIMAL(20, 0),
    vnombretitular       VARCHAR(50),
    dfechavencimiento    DATE,
    nmontoefectivo       DECIMAL(10, 0),
    ncodpasajero         DECIMAL(10, 0),
    ncodtipopago         DECIMAL(10, 0),
    ncodreservacion      DECIMAL(10, 0),
    ncod_tarifa          DECIMAL(10, 0),
    PRIMARY KEY (ncodpago)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaPASAJERO 
--

CREATE TABLE MaPASAJERO(
    ncodpasajero        DECIMAL(10, 0)    NOT NULL,
    vnompasajero        VARCHAR(50),
    vapepasajero        VARCHAR(50),
    vdireccion          VARCHAR(50),
    nedadpasajero       DECIMAL(10, 0),
    vdpi                VARCHAR(20),
    dfechanacimiento    DATE,
    vnopasaporte        VARCHAR(10),
    vestado             VARCHAR(10),
    PRIMARY KEY (ncodpasajero)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaRESERVACION 
--

CREATE TABLE MaRESERVACION(
    ncodreservacion       DECIMAL(10, 0)    NOT NULL,
    dfecha                DATE,
    nanticipo             DECIMAL(20, 0),
    vdescripcionreserv    VARCHAR(50),
    vextranombre          VARCHAR(50),
    nextratelefono        DECIMAL(10, 0),
    vestadoreserv         VARCHAR(30),
    ncodvuelo             DECIMAL(10, 0),
    ncodpasajero          DECIMAL(10, 0),
    PRIMARY KEY (ncodreservacion)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaTARIFA 
--

CREATE TABLE MaTARIFA(
    ncod_tarifa     DECIMAL(10, 0)    NOT NULL,
    vdescripcion    VARCHAR(20),
    nprecio         DECIMAL(10, 0),
    PRIMARY KEY (ncod_tarifa)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaTIPOUSUARIO 
--

CREATE TABLE MaTIPOUSUARIO(
    ncodtipousuario     DECIMAL(0, 0)    NOT NULL,
    vdescripciontipo    VARCHAR(10),
    PRIMARY KEY (ncodtipousuario)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaTIPOVUELO 
--

CREATE TABLE MaTIPOVUELO(
    ncodtipovuelo    DECIMAL(18, 0)    NOT NULL,
    vdescripcion     VARCHAR(10),
    PRIMARY KEY (ncodtipovuelo)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaUSUARIO 
--

CREATE TABLE MaUSUARIO(
    ncodusuario        DECIMAL(10, 0)    NOT NULL,
    vnomusuario        VARCHAR(10),
    vapeusuario        VARCHAR(10),
    vuser              VARCHAR(10),
    vpassword          VARCHAR(10),
    vestado            VARCHAR(10),
    ncodtipousuario    DECIMAL(0, 0),
    PRIMARY KEY (ncodusuario)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaVUELO 
--

CREATE TABLE MaVUELO(
    ncodvuelo           DECIMAL(10, 0)    NOT NULL,
    vlugarsalida        VARCHAR(10),
    dfechavuelo         DATE,
    dthoradespegue      DATETIME,
    dthoraaterrisaje    DATETIME,
    vdisponibilidad     VARCHAR(20),
    nterminal           DECIMAL(10, 0),
    nembarque           DECIMAL(10, 0),
    ncodavion           DECIMAL(10, 0),
    ncodtipovuelo       DECIMAL(18, 0),
    ncodtipodestino     DECIMAL(10, 0),
    PRIMARY KEY (ncodvuelo)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrBITACORA 
--

CREATE TABLE TrBITACORA(
    ncodbitacora    DECIMAL(10, 0)    NOT NULL,
    dfecha          DATE,
    vaccion         VARCHAR(10),
    dthora          DATETIME,
    ncodusuario     DECIMAL(10, 0),
    PRIMARY KEY (ncodbitacora)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrCORREO 
--

CREATE TABLE TrCORREO(
    vcorreo         VARCHAR(30),
    ncodpasajero    DECIMAL(10, 0)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrDESTINO 
--

CREATE TABLE TrDESTINO(
    ncodtipodestino    DECIMAL(10, 0)    NOT NULL,
    vdescripcion       VARCHAR(50),
    PRIMARY KEY (ncodtipodestino)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrRESERVA 
--

CREATE TABLE TrRESERVA(
    ncodreservacion    DECIMAL(10, 0),
    ncodpasajero       DECIMAL(10, 0),
    vasiento           VARCHAR(10)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrTELEFONO 
--

CREATE TABLE TrTELEFONO(
    ntelefono       DECIMAL(10, 0),
    ncodpasajero    DECIMAL(10, 0)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrTIPOAVION 
--

CREATE TABLE TrTIPOAVION(
    ncodtipoavion            DECIMAL(10, 0)    NOT NULL,
    vdescripciontipoavion    VARCHAR(10),
    PRIMARY KEY (ncodtipoavion)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrTIPOPAGO 
--

CREATE TABLE TrTIPOPAGO(
    ncodtipopago        DECIMAL(10, 0)    NOT NULL,
    vdescripcionpago    VARCHAR(10),
    PRIMARY KEY (ncodtipopago)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaAVION 
--

ALTER TABLE MaAVION ADD CONSTRAINT RefTrTIPOAVION1 
    FOREIGN KEY (ncodtipoavion)
    REFERENCES TrTIPOAVION(ncodtipoavion)
;


-- 
-- TABLE: MaPAGO 
--

ALTER TABLE MaPAGO ADD CONSTRAINT RefMaPASAJERO5 
    FOREIGN KEY (ncodpasajero)
    REFERENCES MaPASAJERO(ncodpasajero)
;

ALTER TABLE MaPAGO ADD CONSTRAINT RefTrTIPOPAGO7 
    FOREIGN KEY (ncodtipopago)
    REFERENCES TrTIPOPAGO(ncodtipopago)
;

ALTER TABLE MaPAGO ADD CONSTRAINT RefMaRESERVACION9 
    FOREIGN KEY (ncodreservacion)
    REFERENCES MaRESERVACION(ncodreservacion)
;

ALTER TABLE MaPAGO ADD CONSTRAINT RefMaTARIFA15 
    FOREIGN KEY (ncod_tarifa)
    REFERENCES MaTARIFA(ncod_tarifa)
;


-- 
-- TABLE: MaRESERVACION 
--

ALTER TABLE MaRESERVACION ADD CONSTRAINT RefMaVUELO3 
    FOREIGN KEY (ncodvuelo)
    REFERENCES MaVUELO(ncodvuelo)
;

ALTER TABLE MaRESERVACION ADD CONSTRAINT RefMaPASAJERO4 
    FOREIGN KEY (ncodpasajero)
    REFERENCES MaPASAJERO(ncodpasajero)
;


-- 
-- TABLE: MaUSUARIO 
--

ALTER TABLE MaUSUARIO ADD CONSTRAINT RefMaTIPOUSUARIO8 
    FOREIGN KEY (ncodtipousuario)
    REFERENCES MaTIPOUSUARIO(ncodtipousuario)
;


-- 
-- TABLE: MaVUELO 
--

ALTER TABLE MaVUELO ADD CONSTRAINT RefMaAVION2 
    FOREIGN KEY (ncodavion)
    REFERENCES MaAVION(ncodavion)
;

ALTER TABLE MaVUELO ADD CONSTRAINT RefMaTIPOVUELO10 
    FOREIGN KEY (ncodtipovuelo)
    REFERENCES MaTIPOVUELO(ncodtipovuelo)
;

ALTER TABLE MaVUELO ADD CONSTRAINT RefTrDESTINO11 
    FOREIGN KEY (ncodtipodestino)
    REFERENCES TrDESTINO(ncodtipodestino)
;


-- 
-- TABLE: TrBITACORA 
--

ALTER TABLE TrBITACORA ADD CONSTRAINT RefMaUSUARIO14 
    FOREIGN KEY (ncodusuario)
    REFERENCES MaUSUARIO(ncodusuario)
;


-- 
-- TABLE: TrCORREO 
--

ALTER TABLE TrCORREO ADD CONSTRAINT RefMaPASAJERO13 
    FOREIGN KEY (ncodpasajero)
    REFERENCES MaPASAJERO(ncodpasajero)
;


-- 
-- TABLE: TrRESERVA 
--

ALTER TABLE TrRESERVA ADD CONSTRAINT RefMaRESERVACION16 
    FOREIGN KEY (ncodreservacion)
    REFERENCES MaRESERVACION(ncodreservacion)
;

ALTER TABLE TrRESERVA ADD CONSTRAINT RefMaPASAJERO17 
    FOREIGN KEY (ncodpasajero)
    REFERENCES MaPASAJERO(ncodpasajero)
;


-- 
-- TABLE: TrTELEFONO 
--

ALTER TABLE TrTELEFONO ADD CONSTRAINT RefMaPASAJERO12 
    FOREIGN KEY (ncodpasajero)
    REFERENCES MaPASAJERO(ncodpasajero)
;


