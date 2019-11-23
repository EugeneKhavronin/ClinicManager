import React from 'react';

import ListItemClinic from '../ListItemClinic';
import './listClinic.css';

const ListClinic = ({
  clinicData,
  onDeleted,
  handleClickEditOpen,
  handleClickOpenMore
}) => {
  return (
    <div className="list-clinics">
      {clinicData.map(item => {
        const { guid, ...itemProps } = item;

        return (
          <>
            <ListItemClinic
              {...itemProps}
              key={guid}
              handleClickEditOpen={() => handleClickEditOpen(guid)}
              onDeleted={() => onDeleted(guid)}
              handleClickOpenMore={() => handleClickOpenMore(guid)}
            />
          </>
        );
      })}
    </div>
  );
};

export default ListClinic;
