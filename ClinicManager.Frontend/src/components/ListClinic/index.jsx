import React from 'react';

import './ListClinic.css';
import ListItemClinic from '../ListItemClinic';


const ListClinic = ({ clinicData, onDeleted, onMore }) => {
  const elements = clinicData.length !== 0 ? clinicData.map(item => {
    const { clinicGuid, ...itemProps } = item;
    return (
      <div key={clinicGuid}>
        <ListItemClinic
          {...itemProps}
          onDeleted={() => onDeleted(clinicGuid)}
          onMore={() => onMore(clinicGuid)}
        />
      </div>
    );
  }) : '';
  return <div className="list-group todo-list">{elements}</div>;
};

export default ListClinic;
