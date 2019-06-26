# examples from https://pypi.org/project/fhir.resources/
import fhir.resources as fhir
import json
import jsonschema
import datetime

patient_schema = {
    "resourceType": "Patient",
    # from Resource: id, meta, implicitRules, and language
    # from DomainResource: text, contained, extension, and modifierExtension
    # An identifier for this patient
    "identifier": [{type: fhir.identifier}],
    # Whether this patient's record is in active use
    "active": {type: bool},
    "name": [{type: fhir.humanname}],  # A name associated with the patient
    # A contact detail for the individual
    "telecom": [{type: fhir.contactpoint}],
    # male | female | other | unknown
    "gender": {type: fhir.codesystem.gender},
    "birthDate": {type: datetime},  # The date of birth for the individual
    # deceased[x]: Indicates if the individual is deceased or not. One of these 2:
    "deceasedbool": {type: bool},
    "deceasedDateTime": {type: datetime},
    "address": [{type: fhir.address}],  # An address for the individual
    # Marital (civil) status of a patient
    "maritalStatus": {type: fhir.codeableconcept},
    # multipleBirth[x]: Whether patient is part of a multiple birth. One of these 2:
    "multipleBirthbool": {type: bool},
    "multipleBirthInteger": {type: int},
    "photo": [{type: fhir.attachment}],  # Image of the patient
    "contact": [{  # A contact party (e.g. guardian, partner, friend) for the patient
        # The kind of relationship
        "relationship": [{type: fhir.codeableconcept}],
        # A name associated with the contact person
        "name": {type: fhir.humanname},
        # A contact detail for the person
        "telecom": [{type: fhir.contactpoint}],
        "address": {type: fhir.address},  # Address for the contact person
        "gender": "<code>",  # male | female | other | unknown
        # C? Organization that is associated with the contact
        "organization": {type: fhir.reference},  # Reference(Organization)
        # The period during which this contact person or organization is valid to be contacted relating to this patient
        "period": {type: fhir.period}
    }],
    "communication": [{  # A language which may be used to communicate with the patient about his or her health
        # R!  The language which can be used to communicate with the patient about his or her health
        "language": {type: fhir.codeableconcept},
        "preferred": {type: bool}  # Language preference indicator
    }],
    # Patient's nominated primary care provider
    # Reference(Organization | Practitioner | PractitionerRole)
    "generalPractitioner": [{type: fhir.reference}],
    # Organization that is the custodian of the patient record
    "managingOrganization": {type: fhir.reference},  # Reference(Organization)
    "link": [{  # Link to another patient resource that concerns the same actual person
        # R!  The other patient or related person resource that the link refers to
        "other": {type: fhir.reference},  # Reference(Patient | RelatedPerson)
        "type": "<code>"  # R!  replaced-by | replaces | refer | seealso
    }]
}
