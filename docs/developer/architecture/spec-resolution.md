# Resolution of OpenAPI spec files

- [Spec with just local references](#localRefs)
- [Spec with relative schema document](#relativeSchemaDoc)
- [Spec with references to schema in external OpenAPI file](#refsExternal)
- [Spec with references to schema conflicting schema in the external file.](#conflictingSchemaNames)


## <a name="localRefs"></a>Spec with local references:

The result will be the same file.

### Pre-processed document:

`openapi.yaml`

```
openapi: "3.0.0"
info:
  version: 1.0.0
  title: Swagger Petstore
  license:
    name: MIT
servers:
  - url: http://petstore.swagger.io/v1
components:
  schemas:
    Pet:
      required:
        - id
        - name
      properties:
        id:
          type: integer
          format: int64
        name:
          type: string
        tag:
          type: string
    Pets:
      type: array
      items:
        $ref: "#/components/schemas/Pet"
```

### Resulting spec file:

`openapi-result.yaml`

```
openapi: "3.0.0"
info:
  version: 1.0.0
  title: Swagger Petstore
  license:
    name: MIT
servers:
  - url: http://petstore.swagger.io/v1
components:
  schemas:
    Pet:
      required:
        - id
        - name
      properties:
        id:
          type: integer
          format: int64
        name:
          type: string
        tag:
          type: string
    Pets:
      type: array
      items:
        $ref: "#/components/schemas/Pet"
```

## <a name="relativeSchemaDoc"></a>Spec with relative schema document

The resolved spec will result in the reference being replaced by the referenced value.

### Pre-processed files:

`open-api.yaml`

<pre><code>
openapi: "3.0.0"
info:
  version: 1.0.0
  title: Swagger Petstore
  license:
    name: MIT
servers:
  - url: http://petstore.swagger.io/v1
components:
  schemas:
    Pet:
      $ref: "./pet.yaml"
    Pets:
      type: array
      items:
       <b> $ref: "#/components/schemas/Pet"</b>
</pre></code>

`pet.yaml`

<pre><code>
<b>required:
        - id
        - name
      properties:
        id:
          type: integer
          format: int64
        name:
          type: string
        tag:
          type: string</b>
</pre></code>

### Resulting spec file:

`open-api-result.yaml`

<pre><code>
openapi: "3.0.0"
info:
  version: 1.0.0
  title: Swagger Petstore
  license:
    name: MIT
servers:
  - url: http://petstore.swagger.io/v1
components:
  schemas:
    Pet:
      <b>required:
        - id
        - name
      properties:
        id:
          type: integer
          format: int64
        name:
          type: string
        tag:
          type: string</b>
    Pets:
      type: array
      items:
        $ref: "#/components/schemas/Pet"
</pre></code>

## Spec with references to schema in external OpenAPI file

The resolved spec will result in a document with the external schema added to the document and the external $ref converted to a local reference.

### Pre-processed files:

`openapi.yaml`

<pre><code>
openapi: "3.0.0"
info:
  version: 1.0.0
  title: Swagger Petstore
  license:
    name: MIT
servers:
  - url: http://petstore.swagger.io/v1
paths:
  /pets:
    get:
      summary: List all pets
      operationId: listPets
      tags:
        - pets
      parameters:
        - name: limit
          in: query
          description: How many items to return at one time (max 100)
          required: false
          schema:
            type: integer
            format: int32
      responses:
        '200':
          description: A paged array of pets
          headers:
            x-next:
              description: A link to the next page of responses
              schema:
                type: string
          content:
            application/json:    
              schema:
                $ref: "#/components/schemas/Pets"
    post:
      summary: Create a pet
      operationId: createPets
      tags:
        - pets
      responses:
        '201':
          description: Null response
components:
  schemas:
    Pets:
      type: array
      items:
        <b>$ref: "./external-openapi.json#/components/schemas/Pet"</b>
</pre></code>

`external-openapi.yaml`

<pre><code>
openapi: "3.0.0"
info:
  version: 1.0.0
  title: Swagger Petstore
  license:
    name: MIT
servers:
  - url: http://petstore.swagger.io/v1
components:
  schemas:
    <b>Pet:
      required:
        - id
        - name
      properties:
        id:
          type: integer
          format: int64
        name:
          type: string
        tag:
          type: string</b>
</pre></code>

### Resulting spec file:

`openapi-result.yaml`

<pre><code>
openapi: "3.0.0"
info:
  version: 1.0.0
  title: Swagger Petstore
  license:
    name: MIT
servers:
  - url: http://petstore.swagger.io/v1
components:
  schemas:
    <b>external-openapi_yaml:Pet:
      required:
        - id
        - name
      properties:
        id:
          type: integer
          format: int64
        name:
          type: string
        tag:
          type: string</b>
    Pets:
      type: array
      items:
        <b>$ref: "#/components/schemas/external-openapi_yaml:Pet"</b>
</code></pre>

## <a name="refsExternal"></a>Spec with references to schema in external OpenAPI file

The resolved spec will result in a document with the external schema added to the document and the external $ref converted to a local reference.

### Pre-processed files:

`openapi.yaml`

<pre><code>
openapi: "3.0.0"
info:
  version: 1.0.0
  title: Swagger Petstore
  license:
    name: MIT
servers:
  - url: http://petstore.swagger.io/v1
components:
  schemas:
    Pets:
      type: array
      items:
        <b>$ref: "./external-openapi.json#/components/schemas/Pet"</b>
</pre></code>

`external-openapi.yaml`

<pre><code>
openapi: "3.0.0"
info:
  version: 1.0.0
  title: Swagger Petstore
  license:
    name: MIT
servers:
  - url: http://petstore.swagger.io/v1
components:
  schemas:
    <b>Pet:
      required:
        - id
        - name
      properties:
        id:
          type: integer
          format: int64
        name:
          type: string
        tag:
          type: string</b>
</pre></code>

### Resulting spec file:

`openapi-result.yaml`

<pre><code>
openapi: "3.0.0"
info:
  version: 1.0.0
  title: Swagger Petstore
  license:
    name: MIT
servers:
  - url: http://petstore.swagger.io/v1
components:
  schemas:
    <b>external-openapi_yaml:Pet:
      required:
        - id
        - name
      properties:
        id:
          type: integer
          format: int64
        name:
          type: string
        tag:
          type: string</b>
    Pets:
      type: array
      items:
        <b>$ref: "#/components/schemas/external-openapi_yaml:Pet"</b>
</code></pre>


## <a name="conflictingSchemaNames"></a>Spec with references to conflicting schema in the external file. 

The resolved spec will result in a document with the external schema added to the document and the external $ref converted to a local reference prefixed by the name of the file it came and separated by a colon symbol.

### Pre-processed files:

`openapi.yaml`

<pre><code>
openapi: "3.0.0"
info:
  version: 1.0.0
  title: Swagger Petstore
  license:
    name: MIT
servers:
  - url: http://petstore.swagger.io/v1
components:
  schemas:
    Dogs:
      type: array
      items:
        <b>$ref: "./external-openapi.json#/components/schemas/Dog"</b>
    Pet:
      required:
        - id
        - name
      properties:
        id:
          type: integer
          format: int64
        name:
          type: string
        tag:
          type: string
</pre></code>

`external-openapi.yaml`

<pre><code>
openapi: "3.0.0"
info:
  version: 1.0.0
  title: Swagger Petstore
  license:
    name: MIT
servers:
  - url: http://petstore.swagger.io/v1
components:
  schemas:
    <b>Pet:
      type: object
      required:
        - pet_type
      properties:
        pet_type:
          type: string
      discriminator:
        propertyName: pet_type
    Dog:     
      allOf: 
        - $ref: '#/components/schemas/Pet'
        - type: object
          properties:
            bark:
              type: boolean
            breed:
              type: string
              enum: [Dingo, Husky, Retriever, Shepherd]</b>
    Cat:     
      allOf: 
        - $ref: '#/components/schemas/Pet'
        - type: object
          properties:
            hunts:
              type: boolean
            age:
              type: integer
</pre></code>

### Resulting spec file:

`openapi-result.yaml`

<pre><code>
openapi: "3.0.0"
info:
  version: 1.0.0
  title: Swagger Petstore
  license:
    name: MIT
servers:
  - url: http://petstore.swagger.io/v1
components:
    Dogs:
      type: array
      items:
        <b>$ref: "#/components/schemas/external_openapi_yaml:Dog"</b>
    Pet:
      required:
        - id
        - name
      properties:
        id:
          type: integer
          format: int64
        name:
          type: string
        tag:
          type: string
    <b>external_openapi_yaml:Pet:
      type: object
      required:
        - pet_type
      properties:
        pet_type:
          type: string
      discriminator:
        propertyName: pet_type
    external_openapi_yaml:Dog:     
      allOf: 
        - $ref: '#/components/schemas/external_openapi_yaml:Pet'
        - type: object
          properties:
            bark:
              type: boolean
            breed:
              type: string
              enum: [Dingo, Husky, Retriever, Shepherd]</b>

</code></pre>