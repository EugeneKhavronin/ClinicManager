import React from 'react';

import ListItemClinic from '../ListItemClinic';
import './listClinic.css';

const ListClinic = ({ clinicData, onDeleted, handleClickEditOpen, handleClickOpenMore }) => {
  return (
    <div className="list-clinics">
      {clinicData.map(item => {
        const { clinicGuid, ...itemProps } = item;

        return (
          <>
            <ListItemClinic
              {...itemProps}
              key={clinicGuid}
              handleClickEditOpen={() => handleClickEditOpen(clinicGuid)}
              onDeleted={() => onDeleted(clinicGuid)}
              handleClickOpenMore={() => handleClickOpenMore(clinicGuid)}
            />
          </>
        );
      })}
    </div>
  );
};

export default ListClinic;
