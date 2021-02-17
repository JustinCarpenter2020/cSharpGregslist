CREATE TABLE cars(
  id int NOT NULL AUTO_INCREMENT,
  make varChar(255),
  model varChar(255),
  description varChar(255),
  year int,
  price init,
  url varChar(255)
  PRIMARY KEY (id)
);