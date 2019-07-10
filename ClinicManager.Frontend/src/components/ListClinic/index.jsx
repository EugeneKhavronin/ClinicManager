import React from 'react';

import ListItemClinic from '../ListItemClinic';
import './listClinic.css';

const ListClinic = ({ clinicData, onDeleted, onMore }) => {
  return (
    <div className="list-clinics">
      {clinicData.map(item => {
        const { clinicGuid, ...itemProps } = item;

        return (
          <ListItemClinic
            {...itemProps}
            key={clinicGuid}
            onDeleted={() => onDeleted(clinicGuid)}
            onMore={() => onMore(clinicGuid)}
          />
        );
      })}
    </div>
  );
};

export default ListClinic;
